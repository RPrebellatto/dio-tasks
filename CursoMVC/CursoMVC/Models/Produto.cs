using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo Descrição é obrigatório")]
        public string Descricao { get; set; }
        [Range(minimum: 0, maximum: 99, ErrorMessage = "Quantidade fora dos limites")]
        public int Quantidade { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
