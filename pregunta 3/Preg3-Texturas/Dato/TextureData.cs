using ExamenForm.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
namespace ExamenForm.Dato
{
    public class TextureData
    {
        List<TextureModel> lista = new List<TextureModel>();
        /// <summary>
        /// Guarda las texturas
        /// </summary>
        /// <param name="modelo"></param>
        public void Guardar(TextureModel modelo)
        {
            lista.Add(modelo);
        }
        /// <summary>
        /// Consulta todos las texturas
        /// </summary>
        /// <returns>Tatos de textura</returns>
        public List<TextureModel> Consultar()
        {
            return lista;
        }
    }
}
