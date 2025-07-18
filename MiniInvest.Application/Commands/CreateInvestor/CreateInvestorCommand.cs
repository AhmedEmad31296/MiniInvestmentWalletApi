﻿using MediatR;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniInvest.Application.Commands.CreateInvestor
{
    public record CreateInvestorCommand(string Name, string Email) : IRequest<Guid>;
}
