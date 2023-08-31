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
        public double Diaria { get; set; }
        public Hospede Hospede { get; set; }
        public bool Reservado { get; set; }

        public Quarto(string numero, string descricao, double diaria)
        {
            Numero = numero;
            Descricao = descricao;
            Reservado = false;
            Diaria = diaria;
        }

        public List<Quarto> PreencherInformacoesQuartos()
        {
            List<Quarto> quartos = new List<Quarto>();

            quartos.Add(new Quarto("100", "1 cama de casal, TV, banheiro privativo.", 150.00));
            quartos.Add(new Quarto("101", "1 cama de casal, TV, banheiro privativo.", 160.00));
            quartos.Add(new Quarto("102", "2 camas de solteiro, ar-condicionado, banheiro privativo.", 180.00));
            quartos.Add(new Quarto("103", "1 cama de casal, varanda com vista para o mar.", 200.00));
            quartos.Add(new Quarto("104", "2 camas de solteiro, minibar, banheiro privativo.", 170.00));
            quartos.Add(new Quarto("105", "1 cama de casal, sofá, área de estar.", 190.00));
            quartos.Add(new Quarto("106", "3 camas de solteiro, mesa de trabalho, banheiro privativo.", 210.00));
            quartos.Add(new Quarto("107", "1 cama de casal, jacuzzi, varanda privativa.", 220.00));
            quartos.Add(new Quarto("108", "2 camas de solteiro, TV, banheiro privativo.", 170.00));
            quartos.Add(new Quarto("109", "1 cama de casal, ar-condicionado, minibar.", 180.00));
            quartos.Add(new Quarto("110", "2 camas de solteiro, vista para a cidade.", 160.00));
            quartos.Add(new Quarto("111", "1 cama de casal, área de estar, banheiro com chuveiro e banheira.", 230.00));
            quartos.Add(new Quarto("112", "3 camas de solteiro, mesa de trabalho, banheiro privativo.", 210.00));
            quartos.Add(new Quarto("113", "1 cama de casal, varanda com vista para o mar.", 200.00));
            quartos.Add(new Quarto("114", "2 camas de solteiro, TV, banheiro privativo.", 170.00));
            quartos.Add(new Quarto("115", "1 cama de casal, minibar, banheiro privativo.", 190.00));
            quartos.Add(new Quarto("116", "1 cama de casal, área de estar, vista panorâmica.", 210.00));
            quartos.Add(new Quarto("117", "2 camas de solteiro, ar-condicionado, banheiro privativo.", 180.00));
            quartos.Add(new Quarto("118", "1 cama de casal, varanda privativa, banheiro com banheira.", 220.00));
            quartos.Add(new Quarto("119", "2 camas de solteiro, TV de tela plana, área de estar.", 200.00));
            quartos.Add(new Quarto("120", "1 cama de casal, ar-condicionado, minibar.", 180.00));
            quartos.Add(new Quarto("121", "1 cama de casal, vista para o jardim, banheiro privativo.", 190.00));
            quartos.Add(new Quarto("122", "2 camas de solteiro, área de estar, banheiro com chuveiro.", 210.00));
            quartos.Add(new Quarto("123", "1 cama de casal, varanda com vista para a piscina.", 200.00));
            quartos.Add(new Quarto("124", "1 cama de casal, TV de tela plana, banheiro privativo.", 190.00));

            return quartos;
        }


    }

}
