namespace YahooFinance.Domain.Dtos
{
    public class ApiYahooReturnDto
    {
        public decimal Ask { get; private set; }

        public long AskSize { get; private set; }

        public string AverageAnalystRating { get; private set; } = "";


        public long AverageDailyVolume10Day { get; private set; }

        public long AverageDailyVolume3Month { get; private set; }

        public decimal Bid { get; internal set; }

        public long BidSize { get; private set; }

        public decimal BookValue { get; private set; }

        public bool? CryptoTradeable { get; private set; }

        public string Currency { get; internal set; } = "";


        public string CustomPriceAlertConfidence { get; private set; } = "";


        public string DisplayName { get; private set; } = "";



        public long DividendDateSeconds { get; private set; }




        public long EarningsTimestamp { get; private set; }

        public long EarningsTimestampEnd { get; private set; }

        public long EarningsTimestampStart { get; private set; }


        public decimal? EpsCurrentYear { get; private set; }

        public decimal? EpsForward { get; private set; }

        public decimal? EpsTrailingTwelveMonths { get; private set; }

        public bool? EsgPopulated { get; private set; }

        public string Exchange { get; private set; } = "";



        public long? ExchangeDataDelayedBy { get; private set; }


        public string ExchangeTimezoneName { get; private set; } = "";


        public string ExchangeTimezoneShortName { get; private set; } = "";


        public decimal? FiftyDayAverage { get; private set; }

        public decimal? FiftyDayAverageChange { get; private set; }

        public decimal? FiftyDayAverageChangePercent { get; private set; }

        public decimal? FiftyTwoWeekHigh { get; private set; }

        public decimal? FiftyTwoWeekHighChange { get; private set; }

        public decimal? FiftyTwoWeekHighChangePercent { get; private set; }

        public decimal? FiftyTwoWeekLow { get; private set; }

        public decimal? FiftyTwoWeekLowChange { get; private set; }

        public decimal? FiftyTwoWeekLowChangePercent { get; private set; }

        public string FiftyTwoWeekRange { get; private set; } = "";


        public string FinancialCurrency { get; private set; } = "";



        public long FirstTradeDateMilliseconds { get; private set; }

        public decimal? ForwardPE { get; private set; }

        public string FullExchangeName { get; private set; } = "";


        public long? GmtOffSetMilliseconds { get; private set; }

        public string Language { get; private set; } = "";


        public string LongName { get; private set; } = "";


        public string Market { get; private set; } = "";


        public long? MarketCap { get; private set; }

        public string MarketState { get; private set; } = "";


        public string MessageBoardId { get; private set; } = "";


        public decimal? PostMarketChange { get; private set; }

        public decimal? PostMarketChangePercent { get; private set; }

        public decimal? PostMarketPrice { get; private set; }


        public long PostMarketTimeSeconds { get; private set; }

        public decimal? PreMarketChange { get; private set; }

        public decimal? PreMarketChangePercent { get; private set; }

        public decimal? PreMarketPrice { get; private set; }


        public long PreMarketTimeSeconds { get; private set; }

        public decimal? PriceEpsCurrentYear { get; private set; }

        public long? PriceHint { get; private set; }



        public decimal? PriceToBook { get; private set; }

        public string QuoteSourceName { get; private set; } = "";


        public string QuoteType { get; private set; } = "";


        public string Region { get; private set; } = "";


        public decimal? RegularMarketChange { get; private set; }

        public decimal? RegularMarketChangePercent { get; private set; }

        public decimal? RegularMarketDayHigh { get; private set; }

        public decimal? RegularMarketDayLow { get; private set; }

        public string RegularMarketDayRange { get; private set; } = "";


        public decimal? RegularMarketOpen { get; private set; }

        public decimal? RegularMarketPreviousClose { get; private set; }

        public decimal? RegularMarketPrice { get; private set; }


        public long RegularMarketTimeSeconds { get; private set; }

        public long? RegularMarketVolume { get; private set; }

        public long SharesOutstanding { get; private set; }

        public string ShortName { get; private set; } = "";


        public long? SourceInterval { get; private set; }



        public bool? Tradeable { get; private set; }

        public decimal? TrailingAnnualDividendRate { get; private set; }

        public decimal? TrailingAnnualDividendYield { get; private set; }

        public decimal? TrailingPE { get; private set; }

        public decimal? TrailingThreeMonthNavReturns { get; private set; }

        public decimal? TrailingThreeMonthReturns { get; private set; }

        public bool? Triggerable { get; private set; }

        public decimal? TwoHundredDayAverage { get; private set; }

        public decimal? TwoHundredDayAverageChange { get; private set; }

        public decimal? TwoHundredDayAverageChangePercent { get; private set; }

        public string TypeDisp { get; private set; } = "";


        public decimal? YtdReturn { get; private set; }
    }
}
