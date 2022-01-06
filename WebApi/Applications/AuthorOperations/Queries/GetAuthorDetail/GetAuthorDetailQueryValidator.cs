using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FluentValidation;
using WebApi.DBOperations;

namespace WebApi.Applications.AuthorOperations.Queries.GetAuthorDetail
{
    public class GetAuthorDetailQueryValidator : AbstractValidator<GetAuthorDetailQuery>
    {
        public GetAuthorDetailQueryValidator()
        {
            RuleFor(query => query.AuthorId).GreaterThan(0);
        }
    }
}