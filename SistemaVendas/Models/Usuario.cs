﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaVendas.Models
{
    public class Usuario
    {
        public virtual long Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Sobrenome { get; set; }
        public virtual string Email { get; set; }
        public virtual DateTime DataNascimento { get; set; }
        public virtual string Login { get; set; }
        public virtual string Senha { get; set; }
        public virtual string Foto { get; set; }

        public virtual long Curso { get; set; }
        public virtual long AreasInteresse { get; set; }
        public virtual long NotaAvaliacao { get; set; }
        public virtual long QuantidadeAvaliacao { get; set; }
        public virtual bool Seguindo { get; set; }
        public virtual long QuantidadeSeguidores { get; set; }
        public virtual long QuantidadeSeguindo { get; set; }
        public virtual long Idade { get; set; }
        public virtual long Pontos { get; set; }
        public virtual long QuantidadePublicacoes { get; set; }
        public virtual long QuantidadeResposta { get; set; }


    }
}