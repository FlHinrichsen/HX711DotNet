using System;
using System.Collections.Generic;
using System.Text;

namespace HX711DotNet
{
  using System.Device.Gpio;

  public class HX711Factory : IHX711Factory
    {
        public IHX711 GetHX711(GpioController controller, int dout, int pdSck) => new HX711( controller, (byte)dout, (byte)pdSck);
    }
}
