using AutoMapper;
using CineFlex.Application.Contracts.Persistence;
using CineFlex.Application.Features.Book.CQRS.Commands;
using CineFlex.Application.Features.Seats.CQRS.Commands;
using CineFlex.Application.Features.Seats.DTOs.Validators;
using CineFlex.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineFlex.Application.Features.Book.CQRS.Handlers
{
    public class UpdateBookCommandHandler: IRequestHandler<UpdateBookCommand, BaseCommandResponse<int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public UpdateBookCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<BaseCommandResponse<int>> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse<int>();


            var book = await _unitOfWork.BookRepository.Get(request.bookingDto.Id);

            if (book == null)
            {
                response.Success = false;
                response.Message = "Update Failed";
                return response;
            }

            _mapper.Map(request.bookingDto, book);

            await _unitOfWork.BookRepository.Update(book);
            if (await _unitOfWork.Save() > 0)
            {
                response.Success = true;
                response.Message = "Updated Successful";
                response.Value = 1;
            }
            else
            {
                response.Success = false;
                response.Message = "Update Failed";
            }

            return response;
        }
    }
}
