﻿using System.ComponentModel.DataAnnotations;

namespace ServicoPortaria.Presentation.ViewModels
{
    public class Morador
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(20, ErrorMessage = "Nome Inválido!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(60, ErrorMessage = "Nome Inválido!")]
        public string Sobrenome { get; set; }
        [MinLength(14, ErrorMessage = "Nome Inválido!")]
        [MaxLength(14, ErrorMessage = "Nome Inválido!")]
        public string CPF { get; set; }
        [MinLength(12, ErrorMessage = "Nome Inválido!")]
        [MaxLength(12, ErrorMessage = "Nome Inválido!")]
        public string RG { get; set; }
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(20, ErrorMessage = "Nome Inválido!")]
        public string DocCivil { get; set; }
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(20, ErrorMessage = "Nome Inválido!")]
        public string Sexo { get; set; }
        [MinLength(9, ErrorMessage = "Nome Inválido!")]
        [MaxLength(9, ErrorMessage = "Nome Inválido!")]
        public string CEP { get; set; }
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(20, ErrorMessage = "Nome Inválido!")]
        public string CodigoPostal { get; set; }
        [MinLength(3, ErrorMessage = "Nome Inválido!")]
        [MaxLength(60, ErrorMessage = "Nome Inválido!")]
        public string Rua { get; set; }
        public int Numero { get; set; }
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(30, ErrorMessage = "Nome Inválido!")]
        public string Cidade { get; set; }
        [MinLength(2, ErrorMessage = "Nome Inválido!")]
        [MaxLength(2, ErrorMessage = "Nome Inválido!")]
        public string Estado { get; set; }
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(30, ErrorMessage = "Nome Inválido!")]
        public string Provincia { get; set; }
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(20, ErrorMessage = "Nome Inválido!")]
        public string Pais { get; set; }
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(20, ErrorMessage = "Nome Inválido!")]
        public string Celular { get; set; }
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(20, ErrorMessage = "Nome Inválido!")]
        public string Fixo { get; set; }
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(255, ErrorMessage = "Nome Inválido!")]
        public string EMail { get; set; }
        public int IdCondominio { get; set; }

        public Condominio Condominio { get; set; }
    }
}
