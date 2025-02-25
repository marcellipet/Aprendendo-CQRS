using MediatR;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Domain.Commands.Handlers 
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
                        //Verifica se o cliente já está cadastrado 
            //Valida os dados
            //Insere o cliente no banco
            //Envia email de boas vindas
            var result = new CreateCustomerResponse{
                Id = new Guid(),
                Name = "Marcelli petranela",
                Email = "marcellipetranel@gmail.com",
                Date = DateTime.Now 
            };

            return Task.FromResult(result);
        }
    }
}