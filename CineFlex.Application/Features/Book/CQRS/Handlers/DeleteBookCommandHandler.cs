using AutoMapper;
using CineFlex.Application.Contracts.Persistence;
using CineFlex.Application.Features.Book.CQRS.Commands;
using CineFlex.Application.Features.Seats.CQRS.Commands;
using CineFlex.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineFlex.Application.Features.Book.CQRS.Handlers
{
    public class DeleteBookCommandHandler: IRequestHandler<DeleteBookCommand, BaseCommandResponse<int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteBookCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<BaseCommandResponse<int>> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse<int>();

            var book = await _unitOfWork.BookRepository.Get(request.Id);

            if (book is null)
            {
                response.Success = false;
                response.Message = "Failed find a seat by that Id.";
            }
            else
            {

                await _unitOfWork.BookRepository.Delete(book);


                if (await _unitOfWork.Save() > 0)
                {
                    response.Success = true;
                    response.Message = "Booking deleted Successful";
                    response.Value = book.Id;
                }
                else
                {
                    response.Success = false;
                    response.Message = "Book Deletion Failed";
                }
            }

            return response;
        }
    }
}