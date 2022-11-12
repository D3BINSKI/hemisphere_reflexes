﻿using System.Numerics;
using ObjParser;
using System.Collections.Generic;
using Vector = ObjParser.Types.Vector;

namespace WinFormsApp.GraphicComponents;

public class Render
{
    private readonly int _offset = 20;
    private double _kd;
    private double _ks;
    private double _m;

    public double Kd { get => _kd; set => _kd = value <= 0? 0.01: value >= 1? 0.99: value; }
    public double Ks { get => _ks; set => _ks = value <= 0? 0.01: value >= 1? 0.99: value; }
    public double M { get => _m; set => _m = value < 1? 1: value > 100? 100: value; }

    public List<Face> Faces { get; }
    public List<Vertex> Vertices { get; }
    public IEnumerable<Edge> Edges { get; }

    private double _xSpan;
    private double _ySpan;
    private double _zSpan;

    private (double x, double y, double z) _center;

    private Image _textureImage;
    private Bitmap _textureBitmap;

    public Render(Obj renderedObject, Image textureImage)
    {
        Vertices = new List<Vertex>();
        Faces = new List<Face>();
        
        _ks = 0.5;
        _kd = 0.5;
        _m = 50;

        foreach (var vertex in renderedObject.VertexList)
        {
            var faceContainingCurrentVertex = renderedObject.FaceList.First(face => face.VertexIndexList.Contains(vertex.Index));
            var indexOfVertexInArray = Array.IndexOf(faceContainingCurrentVertex.VertexIndexList, vertex.Index);
            var normalVectorIndex = faceContainingCurrentVertex.NormalVectorIndexList[indexOfVertexInArray];
            var normalVector = renderedObject.NormalVectorList[normalVectorIndex - 1];
            Vertices.Add(new Vertex(new Point3((float)vertex.X, (float)vertex.Y, (float)vertex.Z), vertex.Index, 
                new Vector3((float)normalVector.X, (float)normalVector.Y, (float)normalVector.Z)));
        }

        foreach (var face in renderedObject.FaceList)
        {
            Faces.Add(new Face(Vertices.FindAll(v => face.VertexIndexList.Contains(v.Id))));
        }

        Edges = Faces.SelectMany(face => face.Edges).Distinct();


        _center = ((renderedObject.Size.XMax + renderedObject.Size.XMin) / 2,
            (renderedObject.Size.YMax + renderedObject.Size.YMin) / 2,
            renderedObject.Size.ZMin);
        
        _xSpan = 2 * Math.Max(
            Math.Abs(renderedObject.Size.XMax - _center.x),
            Math.Abs(renderedObject.Size.XMin - _center.x));
        
        _ySpan = 2 * Math.Max(
            Math.Abs(renderedObject.Size.YMax - _center.y),
            Math.Abs(renderedObject.Size.YMin - _center.y));
        
        _zSpan = Math.Abs(renderedObject.Size.ZMax - renderedObject.Size.ZMin);
        
        _textureImage = textureImage;
        _textureBitmap = new Bitmap(_textureImage, (int)_xSpan, (int)_ySpan);
    }

    public void FitToCanvas(float height, float width, int offset)
    {
        var scale = Math.Min(height, width) - offset;
        var kX = scale / _xSpan;
        var kY = scale / _ySpan;
        var kZ = scale / _zSpan / 2;
        _xSpan *= kX;
        _ySpan *= kY;
        _zSpan *= kZ;
        
        MoveCenter(0, 0, 0);
        foreach (var vertex in Vertices)
        {
            vertex.Scale((float)kX, (float)kY, (float)kZ);
        }

        MoveCenter(width/2, height/2, 0);
        
        _textureBitmap = new Bitmap(_textureImage, (int)width, (int)height);
    }

    public void MoveCenter(float x, float y, float z)
    {
        var deltaX = x - _center.x;
        var deltaY = y - _center.y;
        var deltaZ = z - _center.z;

        foreach (var vertex in Vertices)
        {
            vertex.Move((float)deltaX, (float)deltaY, (float)deltaZ);
        }

        _center = (x, y, z);
    }

    public void DrawTopView(Scene scene)
    {
        var bitmap = scene.Bitmap;
        using var graphics = Graphics.FromImage(bitmap.Bitmap);
        
        FitToCanvas(bitmap.Height, bitmap.Width, _offset);
        
        foreach (var edge in Edges)
        {
            edge.DrawXY(graphics);
        }
        // pictureBox.Image = bitmap.Bitmap;
    }

    public void FillFaces(Drawing.Drawing drawing, Bitmap bitmap, Illumination illumination)
    {
        foreach (var face in Faces)
        {
            drawing.FillPolygon(face, _textureBitmap, bitmap, illumination, _kd, _ks, _m);
        }
    }
    
    public void DrawSideView(PictureBox pictureBox)
    {

        var bitmap = pictureBox.Image ?? new Bitmap(pictureBox.Width, pictureBox.Height);
        using var graphics = Graphics.FromImage(bitmap);
        
        MoveCenter(0, 0, 0);
        FitToCanvas(bitmap.Height, bitmap.Width, _offset);
        MoveCenter(bitmap.Width/2, bitmap.Height - 10, 1);

        
        foreach (var edge in Edges)
        {
            edge.DrawXZ(graphics);
        }
        bitmap.RotateFlip(RotateFlipType.Rotate180FlipX);
        pictureBox.Image = bitmap;
    }
}