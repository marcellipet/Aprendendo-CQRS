using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;
using Shop.Domain.Handlers;
using System;


namespace Shop.Domain.Commands.Handlers 
{
    public class CreateCustomerHandler : ICreateCustomerHandler
    {
        public CreateCustomerResponse Handle(CreateCustomerRequest request){
            //Verifica se o cliente já está cadastrado 
            //Valida os dados
            //Insere o cliente no banco
            //Envia email de boas vindas
            return new CreateCustomerResponse{
                Id = new Guid(),
                Name = "Marcelli petranela",
                Email = "marcellipetranel@gmail.com",
                Date = DateTime.Now 
            };
        }
    }
}