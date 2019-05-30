﻿using System;
using System.Collections.Generic;
using System.Text;
using static DDPA.Commons.Enums.DDPAEnums;

namespace DDPA.DTO
{
    public class DocumentFieldDTO
    {
        public int Id { get; set; }

        public int SubModuleId { get; set; }

        public int FieldId { get; set; }

        public string Value { get; set; }

        public string NewValue { get; set; }

        public bool IsEdited { get; set; }

        public string FilePath { get; set; }

        public FieldDTO Field { get; set; }

        public bool File { get; set; }

    }
}
