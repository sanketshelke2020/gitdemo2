﻿using MyCleanProject1.Application.Responses;
using MediatR;

namespace MyCleanProject1.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommand: IRequest<Response<CreateCategoryDto>>
    {
        public string Name { get; set; }
    }
}
