﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjPilhaDinamica {
    internal class Livro {


        public string  Titulo { get; set; }
        public int ISBN { get; set; }
        public string  Autor { get; set; }
        public Livro Anterior { get; set; }

        public Livro(string Titulo, int ISBN, string Autor) {

            this.Titulo = Titulo;
            this.ISBN = ISBN;
            this.Autor = Autor;
            this.Anterior = null;
        }

        public override string ToString() {
            return "\n*** Dados do Livro ***" +
                   "\nTitulo: " + Titulo +
                   "\nAutor: " + Autor +
                   "\nISBN: " + ISBN;
        }


    }
}
