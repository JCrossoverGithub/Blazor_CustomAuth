using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_CustomAuth.Server.Notes
{
    public class Notes
    {


        /*
         *  JSON Web Tokens (JWT)
         *       
         *  A string containing a set of 0 or more name/value pairs (members) as a JSON Object that is encoded in a JWS or a JWE,
         *  enabling the claims to be digitally signed or MACed and/or encrypted.
         *  
         */

        /*
         * The above JSON object is the JWT Claims set.
         * 
         * The JSON object has 0 or more name/value pairs (or members).
         * The names are strings
         * The values are arbitrary JSON values.
         * 
         * The above MEMBERS are claims represented by the JWT.
         * This JSON object MAY contain whitespace and/or line breaks before or after any JSON values or structural characters.
         * 
         */


        /*
         * The member names within the JWT Claims Set are referred to as Claim Names.
         * The corresponding values are called Claim Values. 
         * 
         * The contents of the JOSE Header describe the cryptographic operations applied to the JWT Claims Set. 
         * 
         * If the JOSE Header is for a JWS, 
         *  the JWT is represented as a JWS and the claims are digitally signed or MACed, with the JWT Claims Set being the JWS Payload. 
         * 
         * If the JOSE Header is for a JWE, 
         *  the JWT is represented as a JWE and the claims are encrypted, with the JWT Claims Set being the plaintext encrypted by the JWE. 
         *  
         * A JWT may be enclosed in another JWE or JWS structure to create a Nested JWT, enabling nested signing and encryption to be performed. 
         * 
         */


        /*
         * A JWT is represented as a sequence of URL-safe parts separated by period ('.') characters. 
         * 
         * Each part contains a base64url-encoded value. 
         * 
         * The number of parts in the JWT is dependent upon 
         *  the representation of the resulting JWS using the JWS Compact Serialization or JWE using the JWE Compact Serialization. 
         * 
         */


        /*
         * JWT PRIVACY:
         * 
         * A JWT may contain privacy-sensitive information. 
         * When this is the case, measures MUST be taken to prevent disclosure of this information to unintended parties.
         * 
         * One way to achieve this is to use an encrypted JWT and authenticate the recipient. 
         * 
         * Another way is to ensure that JWTs containing unencrypted privacy-sensitive information are 
         *  only transmitted using protocols utilizing encryption that support endpoint authentication, such as Transport Layer Security (TLS). 
         * 
         * Omitting privacy-sensitive information from a JWT is the simplest way of minimizing privacy issues. 
         * 
         * 
         */



        /*
         * JWT EXAMPLE:
         * 
         * The following example JOSE Header declares that the encoded object is a JWT, 
         *  and the JWT is a JWS that is MACed using the HMAC SHA-256 algorithm: 
         
            {"typ":"JWT",
            "alg":"HS256"}
         
         * 
         * To remove potential ambiguities in the representation of the JSON object above, 
         * the octet sequence for the actual UTF-8 representation used in this example for the JOSE Header above is also included below. 
         * The octets representing the UTF-8 representation of the JOSE Header in this example (using JSON array notation) are:

            [123, 34, 116, 121, 112, 34, 58, 34, 74, 87, 84, 34, 44, 13, 10, 32, 34, 97, 108, 103, 34, 58, 34, 72, 83, 50, 53, 54, 34, 125] 

         * 
         * Encode the octets of the UTF-8 representation of the JOSE Header in Base64url gives this encoded JOSE Header value:
         
            eyJ0eXAiOiJKV1QiLA0KICJhbGciOiJIUzI1NiJ9 
          
         * 
         * The following is an example of a JWT Claims Set:
         * 
         
            {"iss":"joe",
             "exp":1300819380,
             "http://example.com/is_root":true} 
         
         *
         *
         * The following octet sequence, which is the UTF-8 representation used in this example for the JWT Claims Set above, is the JWS Payload:
         
            [123, 34, 105, 115, 115, 34, 58, 34, 106, 111, 101, 34, 44, 13, 10, 32, 34, 101, 120, 112, 34, 58, 49, 51, 48, 48, 56, 49, 57, 51, 56, 48, 44, 13, 10, 32, 34, 104, 116, 116, 112, 58, 47, 47, 101, 120, 97, 109, 112, 108, 101, 46, 99, 111, 109, 47, 105, 115, 95, 114, 111, 111, 116, 34, 58, 116, 114, 117, 101, 125] 
         
         * 
         * 
         * Base64url encoding the JWS Payload yields this encoded JWS Payload (with line breaks for display purposes only): 
         * 
         
            eyJpc3MiOiJqb2UiLA0KICJleHAiOjEzMDA4MTkzODAsDQogImh0dHA6Ly
            9leGFtcGxlLmNvbS9pc19yb290Ijp0cnVlfQ 
         
         * 
         * 
         * Computing the MAC of the encoded JOSE Header and encoded JWS Payload with the HMAC SHA-256 algorithm 
         *  and base64url encoding the HMAC value in the manner specified in [JWS] yields this encoded JWS Signature: 
         
            dBjftJeZ4CVP-mB92K27uhbUJU1p1r_wW1gFWFOEjXk
         
         * 
         * 
         * 
         * Concatenating these encoded parts in this order with period ('.') characters between 
         *  the parts yields this complete JWT (with line breaks for display purposes only): 
         
         eyJ0eXAiOiJKV1QiLA0KICJhbGciOiJIUzI1NiJ9
         .
         eyJpc3MiOiJqb2UiLA0KICJleHAiOjEzMDA4MTkzODAsDQogImh0dHA6Ly9leGFt
         cGxlLmNvbS9pc19yb290Ijp0cnVlfQ
         .
         dBjftJeZ4CVP-mB92K27uhbUJU1p1r_wW1gFWFOEjXk
         


         *
         *
         *
         *
         * 
         */
















        /*
         * OTHER SECURITY NOTES:
         * 
         * GET requests, where variables or resources are altered, are vulnerable to malicious attacks. 
         * GET requests that change state are insecure.                                                   (LOOK INTO THIS INFO IN FUTURE)
         * A best practice is to never change state on a GET request.                                     https://docs.microsoft.com/en-us/aspnet/core/security/anti-request-forgery?view=aspnetcore-6.0#token-based-authentication
         * 
         * 
         * 
         */


        /*
         * LOOK INTO:
         * 
         * Anti-Forgery Tokens
         * 
         * 
         */

    }
}
