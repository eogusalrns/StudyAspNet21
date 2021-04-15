﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetNote.Models
{
    public enum BoardWriteFormType
    {
        Write,
        Modify,
        Reply
    }

    public enum ContentEncodingType
    {
        Text,
        Html,
        Mixed
    }
}