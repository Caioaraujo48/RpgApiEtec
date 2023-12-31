﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace AppRpgEtec.Converters
{
    public class ByteArrayToImageSourceCoverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            ImageSource retSource = null;
            if (value != null) 
            {
                byte[] imageAsByte = (byte[])value;
                retSource = ImageSource.FromStream(() => new MemoryStream(imageAsByte));
            }
            return retSource;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
