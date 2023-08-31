using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apredizado
{
    public class Quarto
    {
        public string Numero { get; set; }
        public string Descricao { get; set; }

        public Quarto(string numero, string descricao)
        {
            Numero = numero;
            Descricao = descricao;
        }

        public List<Quarto> PreencherInformacoesQuartos()
        {
            List<Quarto> Quartos = new List<Quarto>();

            Quartos.Add(new Quarto("100", "1 cama de casal, TV, banheiro privativo."));
            Quartos.Add(new Quarto("101", "1 cama de casal, TV, banheiro privativo."));
            Quartos.Add(new Quarto("102", "2 camas de solteiro, ar-condicionado, banheiro privativo."));
            Quartos.Add(new Quarto("103", "1 cama de casal, varanda com vista para o mar."));
            Quartos.Add(new Quarto("104", "2 camas de solteiro, minibar, banheiro privativo."));
            Quartos.Add(new Quarto("105", "1 cama de casal, sofá, área de estar."));
            Quartos.Add(new Quarto("106", "3 camas de solteiro, mesa de trabalho, banheiro privativo."));
            Quartos.Add(new Quarto("107", "1 cama de casal, jacuzzi, varanda privativa."));
            Quartos.Add(new Quarto("107", "1 cama de casal, jacuzzi, varanda privativa."));
            Quartos.Add(new Quarto("108", "2 camas de solteiro, TV, banheiro privativo."));
            Quartos.Add(new Quarto("109", "1 cama de casal, ar-condicionado, minibar."));
            Quartos.Add(new Quarto("110", "2 camas de solteiro, vista para a cidade."));
            Quartos.Add(new Quarto("111", "1 cama de casal, área de estar, banheiro com chuveiro e banheira."));
            Quartos.Add(new Quarto("112", "3 camas de solteiro, mesa de trabalho, banheiro privativo."));
            Quartos.Add(new Quarto("113", "1 cama de casal, varanda com vista para o mar."));
            Quartos.Add(new Quarto("114", "2 camas de solteiro, TV, banheiro privativo."));
            Quartos.Add(new Quarto("115", "1 cama de casal, minibar, banheiro privativo."));
            Quartos.Add(new Quarto("116", "1 cama de casal, área de estar, vista panorâmica."));
            Quartos.Add(new Quarto("117", "2 camas de solteiro, ar-condicionado, banheiro privativo."));
            Quartos.Add(new Quarto("118", "1 cama de casal, varanda privativa, banheiro com banheira."));
            Quartos.Add(new Quarto("119", "2 camas de solteiro, TV de tela plana, área de estar."));
            Quartos.Add(new Quarto("120", "1 cama de casal, ar-condicionado, minibar."));
            Quartos.Add(new Quarto("121", "1 cama de casal, vista para o jardim, banheiro privativo."));
            Quartos.Add(new Quarto("122", "2 camas de solteiro, área de estar, banheiro com chuveiro."));
            Quartos.Add(new Quarto("123", "1 cama de casal, varanda com vista para a piscina."));
            Quartos.Add(new Quarto("124", "1 cama de casal, TV de tela plana, banheiro privativo."));


            return Quartos; 
        }

    }

}
