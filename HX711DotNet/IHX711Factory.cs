using System;
using System.Collections.Generic;
using System.Text;

namespace HX711DotNet
{
  using System.Device.Gpio;

  public interface IHX711Factory
    {
        IHX711 GetHX711(GpioController controller, int dout, int pdSck);        
    }
}
