<h1>.Net Arabia Libraries</h1>
.Net-Arabia Libraries contains several libraries to support the conversion of several types as shown below to arabic string.

<div class="jumbotron">
    <h1>ArabiaMvc Library</h1>
    <p class="lead">Contains ArabiaController which is responsible for override the default JsonResult behavior by inheriting from ArabiaController your JsonResult action will return Arabic numbers, date, and time.</p>


</div>

<div class="row">
    <h3>Example</h3>
    <pre><code class="prettyprint">
        public class HomeController : ArabiaController
        {
            public JsonResult TestJson()
            {
              var sampleData = new {Byte = (byte)44, Short = (short)-22222, UShort = (ushort)22222, Int = 2144222, Long = 22222222222, Double = 2.5D, Float = 2.2F, Decimal = 22222222222.2m, Date = DateTime.Now};
              return Json(sampleData, JsonRequestBehavior.AllowGet);
            }
        }
    </code></pre>
</div>

<h3>Output</h3>
<pre><code>{
Byte: {
Value: "‎٤‎٤"
},
Short: {
Value: "‎٢‎٢‎٢‎٢‎٢-"
},
UShort: {
Value: "‎٢‎٢‎٢‎٢‎٢"
},
Int: {
Value: "‎٢١‎٤‎٤‎٢‎٢‎٢"
},
Long: {
Value: "‎٢‎٢‎٢‎٢‎٢‎٢‎٢‎٢‎٢‎٢‎٢"
},
Double: {
Value: "‎٢,‎٥"
},
Float: {
Value: "‎٢,‎٢"
},
Decimal: {
Value: "‎٢‎٢‎٢‎٢‎٢‎٢‎٢‎٢‎٢‎٢‎٢,‎٢"
},
Date: {
Value: "‎صباحاً‎ ‎٠‎٨:‎‎٥‎٦ ‎‎٢٠‎١‎٥-‎٠‎٨-‎‎٢٠‎ ‎الخميس‎"
}
}</code></pre>

<div class="jumbotron">
    <h1>ArabiaExtensions Library</h1>
    <p class="lead">Contains Extension Methods for Numeric, Date and Time which converts these types to arabic string (Also DateTime support many formats).</p>
</div>

<h3>Supported Types</h3>
<table class="table table-striped">
    <tr>
        <th>Type</th>
        <th>Input</th>
        <th>Output</th>
    </tr>
    <tr>
        <td>byte</td>
        <td>
            <code class="prettyprint">
                byte x = 222;<br />
                x.ToArabiaString();
            </code>
        </td>
        <td>‎٢‎٢‎٢</td>
    </tr>
    <tr>
        <td>sbyte</td>
        <td>
            <code class="prettyprint">
                sbyte x = -120;<br />
                x.ToArabiaString();
            </code>
        </td>
        <td>١‎٢٠‎-</td>
    </tr>
    <tr>
        <td>Int16 (short)</td>
        <td>
            <code class="prettyprint">
                short x = 21541;<br />
                x.ToArabiaString();
            </code>
        </td>
        <td>‎٢١‎٥‎٤١</td>
    </tr>
    <tr>
        <td>UInt16 (ushort)</td>
        <td>
            <code class="prettyprint">
                ushort x = 52369;<br />
                x.ToArabiaString();
            </code>
        </td>
        <td>‎٥‎٢‎٣‎٦‎٩‎</td>
    </tr>
    <tr>
        <td>Int32 (int)</td>
        <td>
            <code class="prettyprint">
                int x = 2000147;<br />
                x.ToArabiaString();
            </code>
        </td>
        <td>‎٢٠‎٠‎٠‎١‎٤‎٧</td>
    </tr>
    <tr>
        <td>UInt32 (uint)</td>
        <td>
            <code class="prettyprint">
                uint x = 4000147;<br />
                x.ToArabiaString();
            </code>
        </td>
        <td>‎٤٠‎٠‎٠‎١‎٤‎٧</td>
    </tr>
    <tr>
        <td>Int64 (long)</td>
        <td>
            <code class="prettyprint">
                long x = -8223372036854775808;<br />
                x.ToArabiaString();
            </code>
        </td>
        <td>‎٨‎٢‎٢‎٣‎٣‎٧‎٢٠‎‎٣‎٦‎٨‎٥‎٤‎٧‎٧‎٥‎٨٠‎‎٨-</td>
    </tr>
    <tr>
        <td>UInt64 (ulong)</td>
        <td>
            <code class="prettyprint">
                ulong x = 18446744073709551615;<br />
                x.ToArabiaString();
            </code>
        </td>
        <td>١‎٨‎٤‎٤‎٦‎٧‎٤‎٤٠‎‎٧‎٣‎٧٠‎‎٩‎‎٥‎٥١‎٦١‎٥</td>
    </tr>
    <tr>
        <td>Float (float)</td>
        <td>
            <code class="prettyprint">
                float x = -3.402;<br />
                x.ToArabiaString();
            </code>
        </td>
        <td>‎٣,‎٤٠‎‎٢-</td>
    </tr>
    <tr>
        <td>Double (double)</td>
        <td>
            <code class="prettyprint">
                double x = 1500.597;<br />
                x.ToArabiaString();
            </code>
        </td>
        <td>١‎٥٠‎٠‎,‎٥‎٩‎‎٧</td>
    </tr>
    <tr>
        <td>Decimal (decimal)</td>
        <td>
            <code class="prettyprint">
                decimal x = 9000587369.2458793;<br />
                x.ToArabiaString();
            </code>
        </td>
        <td>‎٩‎٠‎٠‎٠‎‎٥‎٨‎٧‎٣‎٦‎٩‎,‎٢‎٤‎٥‎٨‎٧‎٩‎‎٣</td>
    </tr>
    <tr>
        <td>DateTime</td>
        <td>
            <code class="prettyprint">
                DateTime x = DateTime.Now;<br />
                x.ToArabiaString();
            </code>
        </td>
        <td>‎صباحاً‎ ‎٠‎٧:‎‎٣‎٧ ‎‎٢٠‎١‎٥-‎٠‎٨-‎‎٢٠‎ ‎الخميس‎</td>
    </tr>
</table>

<h3>Supported DateTime Formats</h3>

<p></p>
<table class="table table-striped">
<tr>
    <th>Format Specifier</th>
    <th>Description</th>
    <th>Input</th>
    <th>Output</th>
</tr>
<tr>
    <td>"d"</td>
    <td>The day of the month, from 1 through 31.</td>
    <td>
        <code class="prettyprint">
            (new DateTime(2015, 12, 01)).ToArabiaString("d")
            <br/>
            (new DateTime(2015, 12, 11)).ToArabiaString("d")
        </code>
    </td>
    <td>
        ‎١
        <br/>
        ‎١١
    </td>
</tr>
<tr>
    <td>"dd"</td>
    <td>The day of the month, from 01 through 31.</td>
    <td>
        <code class="prettyprint">
            (new DateTime(2015, 12, 01)).ToArabiaString("dd")
            <br/>
            (new DateTime(2015, 12, 11)).ToArabiaString("dd")
        </code>
    </td>
    <td>
        ‎٠١
        <br/>
        ‎١١
    </td>
</tr>
<tr>
    <td>"ddd" or "dddd"</td>
    <td>The full name of the day of the week.</td>
    <td>
        <code class="prettyprint">
            (new DateTime(2015, 12, 01)).ToArabiaString("ddd")
            <br/>
            (new DateTime(2015, 12, 11)).ToArabiaString("dddd")
        </code>
    </td>
    <td>
        ‎الثلاثاء‎
        <br/>
        ‎الجمعة‎
    </td>
</tr>
<tr>
    <td>"M"</td>
    <td>The month, from 1 through 12.</td>
    <td>
        <code class="prettyprint">
            (new DateTime(2015, 05, 01)).ToArabiaString("M")
            <br/>
            (new DateTime(2015, 12, 11)).ToArabiaString("M")
        </code>
    </td>
    <td>
        ‎‎٥
        <br/>
        ‎١‎٢
    </td>
</tr>
<tr>
    <td>"MM"</td>
    <td>The month, from 01 through 12.</td>
    <td>
        <code class="prettyprint">
            (new DateTime(2015, 05, 01)).ToArabiaString("MM")
            <br/>
            (new DateTime(2015, 12, 11)).ToArabiaString("MM")
        </code>
    </td>
    <td>
        ‎٠‎٥
        <br/>
        ‎١‎٢
    </td>
</tr>
<tr>
    <td>"MMM" or "MMMM"</td>
    <td>The full name of the month.</td>
    <td>
        <code class="prettyprint">
            (new DateTime(2015, 05, 01)).ToArabiaString("MMM")
            <br/>
            (new DateTime(2015, 12, 11)).ToArabiaString("MMMM")
        </code>
    </td>
    <td>
        ‎مايو
        <br/>
        ‎ديسمبر
    </td>
</tr>
<tr>
    <td>"yyyy"</td>
    <td>The year as a four-digit number.</td>
    <td>
        <code class="prettyprint">
            (new DateTime(2015, 05, 01)).ToArabiaString("yyyy")
        </code>
    </td>
    <td>
        ‎‎٢٠‎١‎٥
    </td>
</tr>
<tr>
    <td>"yyy"</td>
    <td>The year as a three-digit number.</td>
    <td>
        <code class="prettyprint">
            (new DateTime(2015, 05, 01)).ToArabiaString("yyy")
        </code>
    </td>
    <td>
        ‎٠‎١‎٥
    </td>
</tr>
<tr>
    <td>"yy"</td>
    <td>The year as a two-digit number.</td>
    <td>
        <code class="prettyprint">
            (new DateTime(2015, 05, 01)).ToArabiaString("yy")
        </code>
    </td>
    <td>
        ‎١‎٥
    </td>
</tr>
<tr>
    <td>"h"</td>
    <td>The hour, using a 12-hour clock from 1 to 12.</td>
    <td>
        <code class="prettyprint">
            (new DateTime(2015, 05, 01,15,20,35)).ToArabiaString("h")
            <br/>
            (new DateTime(2015, 12, 11,05,08,09)).ToArabiaString("h")
        </code>
    </td>
    <td>
        ‎٣
        <br/>
        ‎٥
    </td>
</tr>
<tr>
    <td>"hh"</td>
    <td>The hour, using a 12-hour clock from 01 to 12.</td>
    <td>
        <code class="prettyprint">
            (new DateTime(2015, 05, 01,15,20,35)).ToArabiaString("hh")
            <br/>
            (new DateTime(2015, 12, 11,05,08,09)).ToArabiaString("hh")
        </code>
    </td>
    <td>
        ‎٠‎٣
        <br/>
        ‎٠‎٥
    </td>
</tr>
<tr>
    <td>"H"</td>
    <td>The hour, using a 24-hour clock from 0 to 23.</td>
    <td>
        <code class="prettyprint">
            (new DateTime(2015, 05, 01,15,20,35)).ToArabiaString("H")
            <br/>
            (new DateTime(2015, 12, 11,05,08,09)).ToArabiaString("H")
        </code>
    </td>
    <td>
        ‎١‎٥
        <br/>
        ‎‎٥
    </td>
</tr>
<tr>
    <td>"HH"</td>
    <td>The hour, using a 24-hour clock from 00 to 23.</td>
    <td>
        <code class="prettyprint">
            (new DateTime(2015, 05, 01,15,20,35)).ToArabiaString("HH")
            <br/>
            (new DateTime(2015, 12, 11,05,08,09)).ToArabiaString("HH")
        </code>
    </td>
    <td>
        ‎١‎٥
        <br/>
        ‎٠‎٥
    </td>
</tr>
<tr>
    <td>"m"</td>
    <td>The minute, from 0 through 59.</td>
    <td>
        <code class="prettyprint">
            (new DateTime(2015, 05, 01,15,20,35)).ToArabiaString("m")
            <br/>
            (new DateTime(2015, 12, 11,05,08,09)).ToArabiaString("m")
        </code>
    </td>
    <td>
        ‎‎٢٠‎
        <br/>
        ‎‎٨
    </td>
</tr>
<tr>
    <td>"mm"</td>
    <td>The minute, from 00 through 59.</td>
    <td>
        <code class="prettyprint">
            (new DateTime(2015, 05, 01,15,20,35)).ToArabiaString("m")
            <br/>
            (new DateTime(2015, 12, 11,05,08,09)).ToArabiaString("m")
        </code>
    </td>
    <td>
        ‎‎٢٠‎
        <br/>
        ‎‎٨
    </td>
</tr>
<tr>
    <td>"s"</td>
    <td>The second, from 0 through 59.</td>
    <td>
        <code class="prettyprint">
            (new DateTime(2015, 05, 01,15,20,35)).ToArabiaString("s")
            <br/>
            (new DateTime(2015, 12, 11,05,08,09)).ToArabiaString("s")
        </code>
    </td>
    <td>
        ‎‎٣‎٥
        <br/>
        ‎‎٩‎
    </td>
</tr>
<tr>
    <td>"ss"</td>
    <td>The second, from 00 through 59.</td>
    <td>
        <code class="prettyprint">
            (new DateTime(2015, 05, 01,15,20,35)).ToArabiaString("ss")
            <br/>
            (new DateTime(2015, 12, 11,05,08,09)).ToArabiaString("ss")
        </code>
    </td>
    <td>
        ‎‎٣‎٥
        <br/>
        ‎٠‎٩‎
    </td>
</tr>
<tr>
    <td>"t"</td>
    <td>The first character of the AM/PM designator.</td>
    <td>
        <code class="prettyprint">
            (new DateTime(2015, 05, 01,15,20,35)).ToArabiaString("t")
            <br/>
            (new DateTime(2015, 12, 11,05,08,09)).ToArabiaString("t")
        </code>
    </td>
    <td>
        ‎ص‎
        <br/>
        م‎
    </td>
</tr>
<tr>
    <td>"tt"</td>
    <td>The AM/PM designator.</td>
    <td>
        <code class="prettyprint">
            (new DateTime(2015, 05, 01,15,20,35)).ToArabiaString("tt")
            <br/>
            (new DateTime(2015, 12, 11,05,08,09)).ToArabiaString("tt")
        </code>
    </td>
    <td>
        ‎صباحاً‎
        <br/>
        مساءَ‎
    </td>
</tr>
</table>

    

<script src="https://google-code-prettify.googlecode.com/svn/loader/run_prettify.js"></script>



<!-- Visual Studio Browser Link -->
<script type="application/json" id="__browserLink_initializationData">
    {"appName":"Chrome","requestId":"a4703244df4148d0a321c195a74ad088"}
</script>
<script type="text/javascript" src="http://localhost:3214/a276cba0477f4e04b27d78c0114afeb7/browserLink" async="async"></script>
<!-- End Browser Link -->

</body>
</html>
