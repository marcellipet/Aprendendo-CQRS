using MediatR;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Domain.Commands.Handlers 
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
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

        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}