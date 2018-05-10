using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    class Catal
    {
        //Producto[] p = new Producto[15];
        
        int cuantosBan;
        public Producto primero,tmpT;

        public Catal()
        {
            primero = null;
            cuantosBan = 1;
        }

        public void agregarInicio(Producto p2)
        {
            Producto nuevo = new Producto(p2);
            nuevo.siguiente = primero;//ir al primer producto
            primero = nuevo;//Lo coloca en el primero
            cuantosBan++;
        }
        public void agregar(Producto p, Producto lugar)
        {
            if (lugar.siguiente == null)
            {
                lugar.siguiente = p;
            }
            else
            {
                agregar(p, lugar.siguiente);
            }
        }
        private void agregarInv(Producto p)
        {
            if (tmpT == null)
            {
                tmpT = p;
            }
            else
            {
                agregar(p, tmpT);
            }
        }

        private Producto invertir(Producto lugar)
        {
            if (lugar.siguiente != null)
            {
                agregarInv(invertir(lugar.siguiente));
                lugar.siguiente = null;
                return lugar;
            }
            else
            {
                return lugar;
            }
        }

        public void InvertirLista()
        {
            if (primero != null)
            {
                tmpT = null;
                invertir(primero);
                primero.siguiente = null;
                agregarInv(primero);
                primero = tmpT;
            }
        }
        public void Agregar(Producto p)
        {
            Producto nuevo = new Producto(cuantosBan);//agrega el primer producto
            Producto p1, p2;
            if (primero!=null)
            {
                p1 = primero;
                while (p1 != null)
                {
                    p2 = p1.siguiente;
                    //El producto entrante debe ir de primero?
                    if (nuevo.dato <= p1.dato)
                    {
                        nuevo.siguiente = primero;
                        primero = nuevo;
                        break;
                    }
                    else//El producto debe ir al ultimo?
                    {
                        if (nuevo.dato > p1.dato && p2==null)
                        {
                            p1.siguiente = nuevo;
                            nuevo.siguiente = null;
                            break;
                        }
                        else//Debe ir en medio?
                        {
                            if (p1.dato < nuevo.dato && p2.dato >= nuevo.dato)
                            {
                                p1.siguiente = nuevo;
                                nuevo.siguiente = p2;
                                break;
                            }
                            else
                            {
                                p1 = p1.siguiente;
                            }
                        }
                    }
                }
                //nuevo.siguiente = primero;//ir al primer producto
                //primero = nuevo;//Lo coloca en el primero
                cuantosBan++;
            }
            else
            {
                primero = nuevo;
                nuevo.siguiente = null;
                cuantosBan++;
            }
        }

        public string Listar()
        {
            Producto actual = primero;
            string s = "";
            while (actual != null)
            {
                s += actual +Environment.NewLine;
                actual = actual.siguiente;
            }
            return s;
        }

        //public void agregarP(Producto p)
        //{

        //    this.p[cuantosBan] = p;
        //    cuantosBan++;
        //}

        public int getCuantos()
        {
            return cuantosBan;
        }

        //public override string ToString()
        //{
        //    string s = "";
        //    foreach (Producto element in p)
        //    {
        //        s += element+Environment.NewLine;
        //    }
        //    return s;
        //}

        //public string buscarP(int codigo)
        //{
        //    string s = "";
        //    foreach(Producto element in p)
        //    {
        //        if (element.getCodigo() == codigo)
        //        {
        //            s += element + Environment.NewLine;
        //        }
        //    }
        //    return s;
        //}

        //public void eliminarP(int codigo)
        //{
        //    int tmp = 0;
        //    bool bandera = false;
        //    for(int i=0;i<15;i++)
        //    {
        //        if (p[i] != null)
        //        {
        //            if (p[i].getCodigo() == codigo)
        //            {
        //                tmp = i + 1;
        //                p[i+1] = null;
        //                for (i=tmp; i < p.Length; i++)
        //                {
        //                    if (p[i+1] != null)
        //                    {
        //                        p[i] = p[i + 1];
        //                    }
        //                    else if (p[i+1] == null)
        //                    {
        //                        cuantosBan = i + 1;
        //                        break;
        //                    }
        //                }
        //                bandera = true;
        //            }
        //            else if (bandera == true)
        //            {
        //                break;
        //            }
        //        }         
        //    }
            
        //}

    }
}
