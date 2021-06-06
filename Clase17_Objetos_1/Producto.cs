namespace Catalogo //agrupa clases
{
    public class Producto
    {
        //varibables para cada atributo
        
        private string _nombre;
        private string _descripcion;
        private float _precio;
        private string _foto;
        private int _stock;

    //Constructor 
    public Producto(string pNombre)
    {
      _nombre=pNombre;
    }
    //Sobrecarga
    public Producto(string pNombre,int stockInicial)
    {
      _nombre=pNombre;
      _stock=stockInicial;
    }

//Atributos
public string Nombre //Get
{
    get=>_nombre;
}

public int Stock //GetSet
{
    get=>_stock;
}
//METODOS
//tipodevuelto NombreMetodo()
//{//instrucciones}
public bool Comprar(int pCantidad)
{
    if(pCantidad>Stock)
    {
        return false;
    }
    else
    {
        _stock=_stock-pCantidad;
        return true;
        //cuando escribo return No ejecuta mas codigo. Se va de la funcion
    }

}
public void Reponer(int pCantidad)
{
        _stock=_stock+pCantidad;
        
}

} //cierra Clase
} // cierra espacio de nombres