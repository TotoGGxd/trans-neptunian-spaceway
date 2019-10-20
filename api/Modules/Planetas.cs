using System;


namespace api.Modules
{

    public class Planetas
    {
    Int64 id;
    string nombre;
    string description;
    string tamaño;
    string temperatura;
    string rotacion;
    string tiempo;
    string distancia;

    public Planetas(){}
    
    public Planetas ( Int64 id,string nombre, string description, string tamaño, string temperatura, string rotacion, string distancia, string tiempo )
    {
        this. nombre=nombre;
        this.description=description;
        this. tamaño=tamaño;
        this. temperatura=temperatura;
        this. rotacion=rotacion;
        this. tiempo=tiempo;
        this. distancia=distancia;
        this.id=id;
        
    }
    
     

      public string Nombre { get => nombre; set => nombre = value; }
      public string Description { get => description; set => description = value; }
      public string Tamaño { get => tamaño; set => tamaño = value; }
      public string Temperatura { get => temperatura; set =>temperatura = value; }  
      public string Rotacion { get => rotacion; set => rotacion = value; }
      public string Tiempo { get => tiempo; set => tiempo = value; }   
      public string Distancia { get => distancia; set => distancia = value; }  
      public Int64 Id{get=> id; set=> id=value;}

    }
}