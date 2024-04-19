using System;
using System.Collections.Generic;
using System.Text;

namespace HX711DotNet
{
  using System.Device.Gpio;

  public class FakeHX711Factory : IHX711Factory
    {
        public IHX711 GetHX711(GpioController controller, int dout, int pdSck) => new FakeHX711();
    }
}
