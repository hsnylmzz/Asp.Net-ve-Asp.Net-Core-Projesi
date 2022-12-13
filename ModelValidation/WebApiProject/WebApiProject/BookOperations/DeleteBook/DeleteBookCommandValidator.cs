using FluentValidation;
using System;
using System.Linq;
using WebApiProject.DBOperations;

namespace WebApiProject.BookOperations.DeleteBook
{
    public class DeleteBookCommandValidator : AbstractValidator<DeleteBookCommand>
    {
        public DeleteBookCommandValidator()
        {
            RuleFor(command => command.BookId).GreaterThan(0);
        }
    }
}
