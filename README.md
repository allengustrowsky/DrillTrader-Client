# DrillTrader
Drill Trader simulates trading on a real-time platform for trading stocks, index funds, and crypto. The purpose of this is to enable individuals to "paper trade", or practice investing without actually risking real money (a series of self-guided “drills” you could say).  A user can see a few top stocks / index funds on the main page.  These stocks will be sourced from a publicly-available API.  Users can “deposit” money and use that money to buy more assets.  

## Allowed assets (aside from cash): 
- Procter & Gamble Co. (PG)
- Mastercard Inc. (MA)
- Amazon.com Inc. (AMZN)
- Microsoft Corporation (MSFT)
- Berkshire Hathaway Inc. (BRK.A)
- Alphabet Inc. (GOOGL)
- Tesla Inc. (TSLA)
- Coca-Cola Co. (KO)
- JPMorgan Chase & Co. (JPM)
- Exxon Mobil Corporation (XOM)
- Apple Inc. (AAPL)
- Vanguard Total Stock Market ETF (VTI)
- SPDR Dow Jones Industrial Average ETF Trust (DIA)
- SPDR S&P 500 ETF Trust (SPY)
- Binance BTCUSDT (BINANCE:BTCUSDT)

## Setup
- Complete the [backend setup](https://github.com/allengustrowsky/DrillTrader-Server)
- Build and run (Visual Studio conveniently does most of this automatically if the project is run in a VS editor).

## Configuration
- Backend runs on port 3000 by default, frontend runs on port 5258.  If you decide to modify the backend port, change the `BaseAddress` Uri where the `HttpClient` services is added. 

## Limitations / Issues
- Times just use default timezones (probably won't match your timezone)
- Although the backend server receives and stores live price data and is capable of serving it, Blazor is incredibly hard to set up polling with. As a result, the "Trade" page does not update the prices live.  To get up-to-date prices on the main view, the main view page there will have to be refreshed.
- The line chart on the dashboard page poorly labels both axes (works great in the demo but doesn't in this app for some reason). If the y-axis goes into the thousands, then any digits in the thousands place or greater will be cut off. X-axis labeling may not be ideal either.
- The line chart will not show up immediately on the dashboard page. The backend server is set up to record portfolio values every half hour, so waiting a few hours will give it a chance to collect data.