using Alpaca.Markets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockTrading.API.Interfaces
{
  public interface IStockClient
  {
    IAlpacaTradingClient GetStockClient();
  }
}
