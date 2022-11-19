using CommonClassLib.Structures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileParserLib.ObjParser
{
    public static class ObjParser
    {
        public static List<Triangle> ParseObjToTriangleCollection(string filePath)
        {
            var points = new List<Vector>() { null };
            var vectors = new List<Vector>() { null };
            var triangles = new List<Triangle>();

            if (!File.Exists(filePath))
                return null;

            foreach(var line in File.ReadLines(filePath))
            {
                switch(line.Substring(0, 2))
                {
                    case "v ":
                        var pointSplit = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        points.Add(new Vector(
                            float.Parse(pointSplit[1]),
                            float.Parse(pointSplit[2]),
                            float.Parse(pointSplit[3])
                        ));
                        break;

                    case "vn":
                        var vectorSplit = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        vectors.Add(new Vector(
                        
                            float.Parse(vectorSplit[1]),
                            float.Parse(vectorSplit[2]),
                            float.Parse(vectorSplit[3])
                        ));
                        break;

                    case "f ":
                        var firstTriangleSplit = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        var vertices = new List<Vertex>();
                        foreach(var face in firstTriangleSplit.Skip(1))
                        {
                            var secondTriangleSplit = face.Split('/');
                            vertices.Add(new Vertex(
                                points[int.Parse(secondTriangleSplit[0])],
                                vectors[int.Parse(secondTriangleSplit[2])]));
                        }
                        triangles.Add(new Triangle(vertices));
                        break;

                    default:
                        break;
                }
            }

            return triangles;
        }
    }
}
