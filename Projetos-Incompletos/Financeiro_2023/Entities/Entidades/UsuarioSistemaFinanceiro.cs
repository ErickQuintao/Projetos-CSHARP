using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades
{
    [Table("UsuarioSistemaFinanceiro")]
    public class UsuarioSistemaFinanceiro : Base
    {
        public int Id { get; set; }
        public string EmailUsuario { get;}
        public bool Administrador { get; }
        public bool SistemaAtual { get; }
        [ForeignKey("SistemaFinanceiro")]
        [Column(Order = 1)]
        public int IdSistema { get; set; }
        public virtual SistemaFinanceiro SistemaFinanceiro { get; set; }
    }
}
