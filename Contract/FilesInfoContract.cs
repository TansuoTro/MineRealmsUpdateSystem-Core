﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MRUS.Core
{
    public class FilesInfoContract
    {
        private IList<FileUnit> allFileInfoList = new List<FileUnit>();
        public IList<FileUnit> AllFileInfoList
        {
            get { return allFileInfoList; }
            set { allFileInfoList = value; }
        }

    }
}
