﻿using Shift.Core.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shift.Domain.Events.Convenio
{
    public class ConvenioUpdatedEvent : Event
    {
        public ConvenioUpdatedEvent(Guid id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public Guid Id { get; set; }
        public string Nome { get; private set; }
    }
}
