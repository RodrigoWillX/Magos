using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    class Mago
    {
        //Atributos 
        public string nome;
        public int mana, hp, velocidade, defesa, ataque;

        //Metodo construtor
        public Mago(string defineNome, int defineMana, int defineHp, int defineAtaque, int defineDefesa, int defineVelocidade)
        {
            nome = defineNome;
            mana = defineMana;
            hp = defineHp;
            ataque = defineAtaque;
            defesa = defineDefesa;
            velocidade = defineVelocidade;
            Console.WriteLine(nome + " foi criado!");
        }
        //Metodos
        public void Atacar()
        {
            Console.WriteLine(nome + " atacou com forca " + ataque);
        }

        //Metodo defender com parametro inimigo(string)
        public void Defender(string inimigo)
        {
            Console.WriteLine(nome + " defendeu o ataque de " + inimigo);
        }

        public int LancarMagia(string alvo)
        {
            int dano = ataque * mana;
            return dano;
        }

        //Metodo que retorna uma string
        //Parametro tipoMovimenjto (int)
        public string Mover(int tipoMovimento)
        {
            //0 = caminhada
            //1 = corrida
            //2 = teleporte
            string acao = "idle";
            if(tipoMovimento == 0)
            {
                acao = nome + " caminhou!";
            }
            if(tipoMovimento == 1)
            {
                acao = nome + " correu!";
            }
            if(tipoMovimento == 2)
            {
                acao = nome + " se teleportou!";
            }
            return acao;
        }

    }
}
