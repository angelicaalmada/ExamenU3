using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU3
{
    public class Listas
    {
        Nodo primero;
        Nodo ultimo;

        public Listas()
        {
            primero = ultimo = null;
        }

        public bool ListaVacia()
        {
            if (primero == null)
            {
                return true;
            }
            return false;
        }

        public void InsertarElemento(Persona valor)
        {
            if (ListaVacia())
            {
               // Console.WriteLine("La lista esta vacia");
                primero = new Nodo(valor);
            }
            else
            {
                primero = new Nodo(valor, primero);
            }
        }

        public void BuscarNombre(string nombre)
        {
            bool encontrado = false;
            int posicion = 0;
            if (ListaVacia())
            {
                Console.WriteLine("El numero solicitado no existe");
            }
            else
            {
                Nodo actual = primero;
                while (actual != null && encontrado == false)
                {
                    if (actual.getValor().Nombre == nombre)
                    {
                        Console.WriteLine("el elemento se encuentra en la posicion " + posicion);
                        encontrado = true;
                    }
                    else
                    {
                        actual = actual.getSiguiente();
                    }
                    posicion++;

                }
                if (!encontrado)
                {
                    Console.WriteLine("No se encuentra");
                }
            }
        }  

        public void ImprimirLista()
        {
            if (ListaVacia())
            {
                Console.WriteLine("Lista vacia");
            }
            else
            {
                Nodo actual = primero;
                while (actual != null)
                {
                    Console.WriteLine($"Los datos son {actual.getValorString()}");
                    actual = actual.getSiguiente();
                }
                Console.WriteLine("--> null");
            }
        }
    }
}










