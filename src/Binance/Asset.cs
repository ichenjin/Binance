// ReSharper disable InconsistentNaming
using System;
using Binance.Cache;

namespace Binance
{
    /// <summary>
    /// Defined assets (for convenience/reference only).
    /// </summary>
    /// <remarks>File generated by BinanceCodeGenerator tool.</remarks>
    public sealed class Asset : IComparable<Asset>, IEquatable<Asset>
    {
        #region Public Constants

        /// <summary>
        /// When the assets were last updated.
        /// </summary>
        public static readonly long LastUpdateAt = 1525448255603;

        public static Asset ADA => Cache.Get("ADA");
        public static Asset ADX => Cache.Get("ADX");
        public static Asset AE => Cache.Get("AE");
        public static Asset AION => Cache.Get("AION");
        public static Asset AMB => Cache.Get("AMB");
        public static Asset APPC => Cache.Get("APPC");
        public static Asset ARK => Cache.Get("ARK");
        public static Asset ARN => Cache.Get("ARN");
        public static Asset AST => Cache.Get("AST");
        public static Asset BAT => Cache.Get("BAT");
        public static Asset BCC => Cache.Get("BCC");
        public static Asset BCD => Cache.Get("BCD");
        public static Asset BCPT => Cache.Get("BCPT");
        public static Asset BLZ => Cache.Get("BLZ");
        public static Asset BNB => Cache.Get("BNB");
        public static Asset BNT => Cache.Get("BNT");
        public static Asset BQX => Cache.Get("BQX");
        public static Asset BRD => Cache.Get("BRD");
        public static Asset BTC => Cache.Get("BTC");
        public static Asset BTG => Cache.Get("BTG");
        public static Asset BTS => Cache.Get("BTS");
        public static Asset CDT => Cache.Get("CDT");
        public static Asset CHAT => Cache.Get("CHAT");
        public static Asset CLOAK => Cache.Get("CLOAK");
        public static Asset CMT => Cache.Get("CMT");
        public static Asset CND => Cache.Get("CND");
        public static Asset DASH => Cache.Get("DASH");
        public static Asset DGD => Cache.Get("DGD");
        public static Asset DLT => Cache.Get("DLT");
        public static Asset DNT => Cache.Get("DNT");
        public static Asset EDO => Cache.Get("EDO");
        public static Asset ELF => Cache.Get("ELF");
        public static Asset ENG => Cache.Get("ENG");
        public static Asset ENJ => Cache.Get("ENJ");
        public static Asset EOS => Cache.Get("EOS");
        public static Asset ETC => Cache.Get("ETC");
        public static Asset ETH => Cache.Get("ETH");
        public static Asset EVX => Cache.Get("EVX");
        public static Asset FUEL => Cache.Get("FUEL");
        public static Asset FUN => Cache.Get("FUN");
        public static Asset GAS => Cache.Get("GAS");
        public static Asset GNT => Cache.Get("GNT");
        public static Asset GRS => Cache.Get("GRS");
        public static Asset GTO => Cache.Get("GTO");
        public static Asset GVT => Cache.Get("GVT");
        public static Asset GXS => Cache.Get("GXS");
        public static Asset HSR => Cache.Get("HSR");
        public static Asset ICN => Cache.Get("ICN");
        public static Asset ICX => Cache.Get("ICX");
        public static Asset INS => Cache.Get("INS");
        public static Asset IOST => Cache.Get("IOST");
        public static Asset IOTA => Cache.Get("IOTA");
        public static Asset KMD => Cache.Get("KMD");
        public static Asset KNC => Cache.Get("KNC");
        public static Asset LEND => Cache.Get("LEND");
        public static Asset LINK => Cache.Get("LINK");
        public static Asset LOOM => Cache.Get("LOOM");
        public static Asset LRC => Cache.Get("LRC");
        public static Asset LSK => Cache.Get("LSK");
        public static Asset LTC => Cache.Get("LTC");
        public static Asset LUN => Cache.Get("LUN");
        public static Asset MANA => Cache.Get("MANA");
        public static Asset MCO => Cache.Get("MCO");
        public static Asset MDA => Cache.Get("MDA");
        public static Asset MOD => Cache.Get("MOD");
        public static Asset MTH => Cache.Get("MTH");
        public static Asset MTL => Cache.Get("MTL");
        public static Asset NANO => Cache.Get("NANO");
        public static Asset NAV => Cache.Get("NAV");
        public static Asset NCASH => Cache.Get("NCASH");
        public static Asset NEBL => Cache.Get("NEBL");
        public static Asset NEO => Cache.Get("NEO");
        public static Asset NULS => Cache.Get("NULS");
        public static Asset OAX => Cache.Get("OAX");
        public static Asset OMG => Cache.Get("OMG");
        public static Asset ONT => Cache.Get("ONT");
        public static Asset OST => Cache.Get("OST");
        public static Asset PIVX => Cache.Get("PIVX");
        public static Asset POA => Cache.Get("POA");
        public static Asset POE => Cache.Get("POE");
        public static Asset POWR => Cache.Get("POWR");
        public static Asset PPT => Cache.Get("PPT");
        public static Asset QLC => Cache.Get("QLC");
        public static Asset QSP => Cache.Get("QSP");
        public static Asset QTUM => Cache.Get("QTUM");
        public static Asset RCN => Cache.Get("RCN");
        public static Asset RDN => Cache.Get("RDN");
        public static Asset REQ => Cache.Get("REQ");
        public static Asset RLC => Cache.Get("RLC");
        public static Asset RPX => Cache.Get("RPX");
        public static Asset SALT => Cache.Get("SALT");
        public static Asset SNGLS => Cache.Get("SNGLS");
        public static Asset SNM => Cache.Get("SNM");
        public static Asset SNT => Cache.Get("SNT");
        public static Asset STEEM => Cache.Get("STEEM");
        public static Asset STORJ => Cache.Get("STORJ");
        public static Asset STORM => Cache.Get("STORM");
        public static Asset STRAT => Cache.Get("STRAT");
        public static Asset SUB => Cache.Get("SUB");
        public static Asset SYS => Cache.Get("SYS");
        public static Asset TNB => Cache.Get("TNB");
        public static Asset TNT => Cache.Get("TNT");
        public static Asset TRIG => Cache.Get("TRIG");
        public static Asset TRX => Cache.Get("TRX");
        public static Asset USDT => Cache.Get("USDT");
        public static Asset VEN => Cache.Get("VEN");
        public static Asset VIA => Cache.Get("VIA");
        public static Asset VIB => Cache.Get("VIB");
        public static Asset VIBE => Cache.Get("VIBE");
        public static Asset WABI => Cache.Get("WABI");
        public static Asset WAN => Cache.Get("WAN");
        public static Asset WAVES => Cache.Get("WAVES");
        public static Asset WINGS => Cache.Get("WINGS");
        public static Asset WPR => Cache.Get("WPR");
        public static Asset WTC => Cache.Get("WTC");
        public static Asset XEM => Cache.Get("XEM");
        public static Asset XLM => Cache.Get("XLM");
        public static Asset XMR => Cache.Get("XMR");
        public static Asset XRP => Cache.Get("XRP");
        public static Asset XVG => Cache.Get("XVG");
        public static Asset XZC => Cache.Get("XZC");
        public static Asset YOYO => Cache.Get("YOYO");
        public static Asset ZEC => Cache.Get("ZEC");
        public static Asset ZIL => Cache.Get("ZIL");
        public static Asset ZRX => Cache.Get("ZRX");

        // Redirect (BCH) Bitcoin Cash (BCC = BitConnect)
        public static Asset BCH => BCC;

        #endregion Public Constants

        #region Implicit Operators

        public static bool operator ==(Asset x, Asset y) => Equals(x, y);

        public static bool operator !=(Asset x, Asset y) => !(x == y);

        public static implicit operator string(Asset asset) => asset?.ToString();

        #endregion Implicit Operators

        #region Public Properties

        /// <summary>
        /// Asset cache.
        /// </summary>
        public static IObjectCache<Asset> Cache { get; set; }

        /// <summary>
        /// Get the asset symbol.
        /// </summary>
        public string Symbol { get; }

        /// <summary>
        /// Get the asset precision.
        /// </summary>
        public int Precision { get; }

        #endregion Public Properties

        #region Private Fields

        private static readonly object _sync = new object();

        #endregion Private Fields

        #region Constructors

        static Asset()
        {
            try
            {
                Cache = new InMemoryCache<Asset>();

                Cache.Set(
                    new[] {
                        new Asset("ADA", 8),
                        new Asset("ADX", 8),
                        new Asset("AE", 8),
                        new Asset("AION", 8),
                        new Asset("AMB", 8),
                        new Asset("APPC", 8),
                        new Asset("ARK", 8),
                        new Asset("ARN", 8),
                        new Asset("AST", 8),
                        new Asset("BAT", 8),
                        new Asset("BCC", 8),
                        new Asset("BCD", 8),
                        new Asset("BCPT", 8),
                        new Asset("BLZ", 8),
                        new Asset("BNB", 8),
                        new Asset("BNT", 8),
                        new Asset("BQX", 8),
                        new Asset("BRD", 8),
                        new Asset("BTC", 8),
                        new Asset("BTG", 8),
                        new Asset("BTS", 8),
                        new Asset("CDT", 8),
                        new Asset("CHAT", 8),
                        new Asset("CLOAK", 8),
                        new Asset("CMT", 8),
                        new Asset("CND", 8),
                        new Asset("DASH", 8),
                        new Asset("DGD", 8),
                        new Asset("DLT", 8),
                        new Asset("DNT", 8),
                        new Asset("EDO", 8),
                        new Asset("ELF", 8),
                        new Asset("ENG", 8),
                        new Asset("ENJ", 8),
                        new Asset("EOS", 8),
                        new Asset("ETC", 8),
                        new Asset("ETH", 8),
                        new Asset("EVX", 8),
                        new Asset("FUEL", 8),
                        new Asset("FUN", 8),
                        new Asset("GAS", 8),
                        new Asset("GNT", 8),
                        new Asset("GRS", 8),
                        new Asset("GTO", 8),
                        new Asset("GVT", 8),
                        new Asset("GXS", 8),
                        new Asset("HSR", 8),
                        new Asset("ICN", 8),
                        new Asset("ICX", 8),
                        new Asset("INS", 8),
                        new Asset("IOST", 8),
                        new Asset("IOTA", 8),
                        new Asset("KMD", 8),
                        new Asset("KNC", 8),
                        new Asset("LEND", 8),
                        new Asset("LINK", 8),
                        new Asset("LOOM", 8),
                        new Asset("LRC", 8),
                        new Asset("LSK", 8),
                        new Asset("LTC", 8),
                        new Asset("LUN", 8),
                        new Asset("MANA", 8),
                        new Asset("MCO", 8),
                        new Asset("MDA", 8),
                        new Asset("MOD", 8),
                        new Asset("MTH", 8),
                        new Asset("MTL", 8),
                        new Asset("NANO", 8),
                        new Asset("NAV", 8),
                        new Asset("NCASH", 8),
                        new Asset("NEBL", 8),
                        new Asset("NEO", 8),
                        new Asset("NULS", 8),
                        new Asset("OAX", 8),
                        new Asset("OMG", 8),
                        new Asset("ONT", 8),
                        new Asset("OST", 8),
                        new Asset("PIVX", 8),
                        new Asset("POA", 8),
                        new Asset("POE", 8),
                        new Asset("POWR", 8),
                        new Asset("PPT", 8),
                        new Asset("QLC", 8),
                        new Asset("QSP", 8),
                        new Asset("QTUM", 8),
                        new Asset("RCN", 8),
                        new Asset("RDN", 8),
                        new Asset("REQ", 8),
                        new Asset("RLC", 8),
                        new Asset("RPX", 8),
                        new Asset("SALT", 8),
                        new Asset("SNGLS", 8),
                        new Asset("SNM", 8),
                        new Asset("SNT", 8),
                        new Asset("STEEM", 8),
                        new Asset("STORJ", 8),
                        new Asset("STORM", 8),
                        new Asset("STRAT", 8),
                        new Asset("SUB", 8),
                        new Asset("SYS", 8),
                        new Asset("TNB", 8),
                        new Asset("TNT", 8),
                        new Asset("TRIG", 8),
                        new Asset("TRX", 8),
                        new Asset("USDT", 8),
                        new Asset("VEN", 8),
                        new Asset("VIA", 8),
                        new Asset("VIB", 8),
                        new Asset("VIBE", 8),
                        new Asset("WABI", 8),
                        new Asset("WAN", 8),
                        new Asset("WAVES", 8),
                        new Asset("WINGS", 8),
                        new Asset("WPR", 8),
                        new Asset("WTC", 8),
                        new Asset("XEM", 8),
                        new Asset("XLM", 8),
                        new Asset("XMR", 8),
                        new Asset("XRP", 8),
                        new Asset("XVG", 8),
                        new Asset("XZC", 8),
                        new Asset("YOYO", 8),
                        new Asset("ZEC", 8),
                        new Asset("ZIL", 8),
                        new Asset("ZRX", 8),
                    });

                AddCacheRedirections();
            }
            catch (Exception e)
            {
                Console.Error?.WriteLine($"{nameof(Binance)}.{nameof(Asset)}(): \"{e.Message}\"");
            }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="symbol">The asset symbol.</param>
        /// <param name="precision">The asset precision.</param>
        public Asset(string symbol, int precision)
        {
            if (string.IsNullOrWhiteSpace(symbol))
                throw new ArgumentNullException(nameof(symbol));

            Symbol = string.Intern(symbol.ToUpperInvariant());
            Precision = precision;
        }

        #endregion Constructors

        #region Public Methods

        /// <summary>
        /// Verify that asset is valid. If fails, but known to be valid,
        /// call Symbol.UpdateCacheAsync() to get the latest assets.
        /// </summary>
        /// <param name="asset"></param>
        /// <returns></returns>
        public static bool IsValid(string asset)
        {
            if (string.IsNullOrWhiteSpace(asset))
                return false;

            asset = asset.FormatSymbol();

            return Cache.Get(asset) == asset;
        }

        public override bool Equals(object obj)
        {
            // ReSharper disable once ConvertIfStatementToSwitchStatement
            if (obj == null)
                return false;

            if (obj is Asset asset)
                return Equals(asset);

            return Symbol.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Symbol.GetHashCode();
        }

        public override string ToString()
        {
            return Symbol;
        }

        #endregion Public Methods

        #region Internal Methods

        internal static void AddCacheRedirections()
        {
            // Redirect (BCH) Bitcoin Cash (BCC = BitConnect)
            Cache.Set("BCH", Cache.Get("BCC"));
        }

        #endregion Internal Methods

        #region IComparable<Asset>

        public int CompareTo(Asset other)
        {
            return other == null ? 1 : string.Compare(Symbol, other.Symbol, StringComparison.Ordinal);
        }

        #endregion IComparable<Asset>

        #region IEquatable<Asset>

        public bool Equals(Asset other)
        {
            return CompareTo(other) == 0;
        }

        #endregion IEquatable<Asset>
    }
}
