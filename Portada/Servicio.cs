﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//json
//using System.Web.Script.Serialization;
//peticiones web
using System.Net;
//flujo de datos
using System.IO;


namespace Portada
{
    class Servicio
    {
        private string url { get; set; }

        private HttpWebRequest httpRequest { get; set; }

        private HttpWebResponse httpResponse { get; set; }

        private StreamWriter streamWriter { get; set; }

        private StreamReader streamReader { get; set; }

        private string body { get; set; }

        private string results { get; set; }

        public Servicio()
        {
            url = "http://localhost/servicioWebGE/";
            httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.ContentType = "application/json";
            httpRequest.Method = "POST";

            streamWriter = new StreamWriter(httpRequest.GetRequestStream());
        }

        public string llamarServicio(string parametros)
        {
            //peticion al servivio
            body = parametros;
            streamWriter.InitializeLifetimeService();
            streamWriter.Write(body);
            streamWriter.Flush();
            //respuesta de web service
            httpResponse = (HttpWebResponse)httpRequest.GetResponse();

            using (streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                results = streamReader.ReadToEnd();
            }

            return results;
        }
    }
}
