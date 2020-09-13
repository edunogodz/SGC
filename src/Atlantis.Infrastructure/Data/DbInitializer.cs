using Atlantis.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atlantis.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ClienteContext context)
        {
            if (context.Clientes.Any())
            {
                return;
            }

            var clientes = new Cliente[]
            {
                new Cliente()
                {
                    Nome = "Fulano",
                    CPF = "11111111111"
                },
                new Cliente()
                {
                    Nome = "Beltrano",
                    CPF = "22222222222"
                },
                new Cliente()
                {
                    Nome = "Ciclano",
                    CPF = "33333333333"
                }
            };

            context.AddRange(clientes);

            var contatos = new Contato[]
            {
                new Contato
                {
                    Nome = "Contato 1",
                    Telefone = "123456789",
                    Email = "fulano@fulano.com",
                    Cliente = clientes[0]
                },
                new Contato
                {
                    Nome = "Contato 2",
                    Telefone = "2222222222",
                    Email = "beltrano@beltrano.com",
                    Cliente = clientes[1]
                },
                new Contato
                {
                    Nome = "Contato 3",
                    Telefone = "3333333333",
                    Email = "ciclanociclano.com",
                    Cliente = clientes[2]
                }
            };
        }
    }
}
