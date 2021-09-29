using System;
using System.Collections.Generic;

namespace HomeWorkGB
{
    public interface IGraph
    {
        void AddVertex(int value); // добавить вершину
        void AddEdge(int value1, int value2, int weight);
        void RemoveVertex(int value); // удалить вершину по значению
        Vertex GetVertexByValue(int value); //получить вершину графа по значению
        void PrintGraph(); //вывести граф в консоль
    }

    public class Graph : IGraph
    {
        public List<Vertex> Vertexes = new List<Vertex>();
        public Graph()
        {
        }
        public Graph(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                AddVertex(i);
            }
        }
        public void AddEdge(int startvalue, int endvalue, int weight)
        {
            var vertex1 = GetVertexByValue(startvalue);
            var vertex2 = GetVertexByValue(endvalue);
            if (vertex1 == null || vertex2 == null)
                return;
            var edge = new Edge() { Vert1 = vertex1, Vert2 = vertex2, Weight = weight };
            vertex1.Edges.Add(edge);
            vertex2.Edges.Add(edge);
        }

        public void AddVertex(int value)
        {
            var vertex = new Vertex() { Value = value };
            Vertexes.Add(vertex);
        }

        public Vertex GetVertexByValue(int value)
        {
            foreach (var item in Vertexes)
            {
                if (item.Value == value)
                    return item;
            }
            Vertex zero = new Vertex();
            return zero;
        }
        public void PrintGraph()
        {
            foreach (var v in Vertexes)
            {
                Console.WriteLine("Вершина со значением - " + v.Value);
                foreach (var edge in v.Edges)
                {
                    Console.WriteLine($"Имеет ребро между вершинами со значениями - {edge.Vert1.Value} и {edge.Vert2.Value}, вес ребра  - {edge.Weight}.");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public void RemoveVertex(int value)
        {
            var vertex = GetVertexByValue(value);
            for (int i = 0; i < vertex.Edges.Count; i++)
            {
                if (vertex.Edges[i].Vert1?.Value == value)
                {
                    for (int j = 0; j < vertex.Edges[i].Vert2.Edges.Count; j++)
                    {
                        if (vertex.Edges[i].Vert1?.Edges[j].Vert1?.Value == value || vertex.Edges[i].Vert1?.Edges[j].Vert2?.Value == value)
                        {
                            vertex.Edges[i].Vert1.Edges.RemoveAt(j);
                        }  
                    }
                    vertex.Edges.RemoveAt(i);
                }
                if (vertex.Edges[i].Vert2?.Value == value)
                {
                    for (int j = 0; j < vertex.Edges[i].Vert1.Edges.Count; j++)
                    {
                        if (vertex.Edges[i].Vert2?.Edges[j].Vert1?.Value == value || vertex.Edges[i].Vert2?.Edges[j].Vert2?.Value == value)
                        {
                            vertex.Edges[i].Vert2?.Edges.RemoveAt(j);
                            break;
                        }
                    }
                    vertex.Edges.RemoveAt(i);
                }

            }
            for (int i = 0; i < Vertexes.Count; i++)
            {
                if (vertex == Vertexes[i])
                {
                    Vertexes.RemoveAt(i);
                }    
            }
        }
    }
    public class Vertex
    {
        public int Value { get; set; }
        public List<Edge> Edges = new List<Edge>();
    }
    public class Edge
    {
        public int Weight { get; set; }
        public Vertex Vert1 { get; set; }
        public Vertex Vert2 { get; set; }
    }
}
