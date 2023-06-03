using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace CursoWindowsFormsBiblioteca.Classes
{
    public class Cliente
    {
        public class Unit
        {
            [Required(ErrorMessage = "O código do Cliente é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "O código do Cliente somente aceita valores numéricos")]
            [StringLength(6, MinimumLength = 6, ErrorMessage = "Código do Cliente deve ter 6 dígitos")]
            public string? Id { get; set; }

            [Required(ErrorMessage = "O nome do Cliente é obrigatório")]
            [StringLength(50, ErrorMessage = "O nome do Cliente deve ter no máximo 50 caracteres")]
            public string? Nome { get; set; }

            [StringLength(50, ErrorMessage = "O nome do Pai deve ter no máximo 50 caracteres")]
            public string? NomePai { get; set; }

            [Required(ErrorMessage = "O nome da Mãe é obrigatório")]
            [StringLength(50, ErrorMessage = "Código do Cliente deve ter no máximo 50 caracteres")]
            public string? NomeMae { get; set; }

            public bool NaoTemPai { get; set; }

            [Required(ErrorMessage = "O CPF é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "O CPF somente aceita valores numéricos")]
            [StringLength(11, MinimumLength = 11, ErrorMessage = "Código do Cliente deve ter 11 dígitos")]
            public string? Cpf { get; set; }

            [Required(ErrorMessage = "O gênero é obrigatório")]
            public int Genero { get; set; }

            [Required(ErrorMessage = "O CEP é obrigatório")]
            [StringLength(8, MinimumLength = 8, ErrorMessage = "Código do Cliente deve ter no máximo 8 caracteres")]
            public string? Cep { get; set; }

            [Required(ErrorMessage = "O logradouro é obrigatório")]
            [StringLength(100, ErrorMessage = "O logradouro deve ter no máximo 100 caracteres")]
            public string? Logradouro { get; set; }

            [Required(ErrorMessage = "O bairro é obrigatório")]
            [StringLength(50, ErrorMessage = "O bairro deve ter no máximo 50 caracteres")]
            public string? Bairro { get; set; }

            [StringLength(50, ErrorMessage = "O complemento deve ter no máximo 50 caracteres")]
            public string? Complemento { get; set; }

            [Required(ErrorMessage = "A cidade é obrigatória")]
            [StringLength(50, ErrorMessage = "A cidade deve ter no máximo 50 caracteres")]
            public string? Cidade { get; set; }

            [Required(ErrorMessage = "O Estado é obrigatório")]
            [StringLength(50, ErrorMessage = "O Estado deve ter no máximo 50 caracteres")]
            public string? Estado { get; set; }

            [Required(ErrorMessage = "O número de telefone é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "O número de telefone somente aceita valores numéricos")]
            public string? Telefone { get; set; }

            public string? Profissao { get; set; }

            [Required(ErrorMessage = "A renda familiar é obrigatória")]
            [Range(0, double.MaxValue, ErrorMessage = "A Renda Familiar deve ser um valor positivo")]
            public double RendaFamiliar { get; set; }

            public void ValidaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());
                }
            }

            public void ValidaComplemento()
            {
                if (this.NomePai == this.NomeMae)
                {
                    throw new Exception("Nome do Pai e da Mãe não podem ser iguais");
                }

                if (this.NaoTemPai == false)
                {
                    if (this.NomePai == "")
                    {
                        throw new Exception("O nome do Pai não pode estar vazio quando a propriedade Pai não estiver marcada");
                    }
                }

                bool validaCPF = Cls_Uteis.Valida(Cpf);
                if (validaCPF == false)
                {
                    throw new Exception("CPF inválido");
                }
            }
        }

        public class List
        {
            public List<Unit>? ListUnit {get; set;}
        }

        public static Unit DesSerializedClassUnit(string vJson)
        {
            return JsonConvert.DeserializeObject<Unit>(vJson);
        }

        public static string SerializedClassUnit(Unit unit)
        {
            return JsonConvert.SerializeObject(unit);
        }
    }
}
