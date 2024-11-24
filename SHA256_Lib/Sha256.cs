using System.Text;

namespace SHA256Lib;

public class Sha256
{
    // Constants for SHA-256
    private static readonly uint[] K =
    {
        0x428a2f98, 0x71374491, 0xb5c0fbcf, 0xe9b5dba5, 0x3956c25b, 0x59f111f1, 0x923f82a4, 0xab1c5ed5,
        0xd807aa98, 0x12835b01, 0x243185be, 0x550c7dc3, 0x72be5d74, 0x80deb1fe, 0x9bdc06a7, 0xc19bf174,
        0xe49b69c1, 0xefbe4786, 0x0fc19dc6, 0x240ca1cc, 0x2de92c6f, 0x4a7484aa, 0x5cb0a9dc, 0x76f988da,
        0x983e5152, 0xa831c66d, 0xb00327c8, 0xbf597fc7, 0xc6e00bf3, 0xd5a79147, 0x06ca6351, 0x14292967,
        0x27b70a85, 0x2e1b2138, 0x4d2c6dfc, 0x53380d13, 0x650a7354, 0x766a0abb, 0x81c2c92e, 0x92722c85,
        0xa2bfe8a1, 0xa81a664b, 0xc24b8b70, 0xc76c51a3, 0xd192e819, 0xd6990624, 0xf40e3585, 0x106aa070,
        0x19a4c116, 0x1e376c08, 0x2748774c, 0x34b0b5e1, 0x391c0cb3, 0x4ed8aa4a, 0x5b9cca4f, 0x682e6ff3,
        0x748f82ee, 0x78a5636f, 0x84c87814, 0x8cc70208, 0x90befffa, 0xa4506ceb, 0xbef9a3f7, 0xc67178f2
    };

    // Initial hash values (H0 to H7)
    private static readonly uint[] H =
    {
        0x6a09e667, 0xbb67ae85, 0x3c6ef372, 0xa54ff53a, 0x510e527f, 0x9b05688c, 0x1f83d9ab, 0x5be0cd19
    };

    public static string ComputeSHA256(string input)
    {
        byte[] message = Encoding.ASCII.GetBytes(input);

        // Pre-processing: Padding
        byte[] paddedMessage = PadMessage(message);

        // Initialize hash values
        uint[] hashValues = (uint[])H.Clone();

        // Process each 512-bit block
        for (int i = 0; i < paddedMessage.Length / 64; i++)
        {
            byte[] block = new byte[64];
            Array.Copy(paddedMessage, i * 64, block, 0, 64);
            ProcessBlock(block, hashValues);
        }

        // Convert the hash values to a hexadecimal string
        StringBuilder hexResult = new StringBuilder();
        foreach (var h in hashValues)
        {
            hexResult.AppendFormat("{0:x8}", h);
        }

        return hexResult.ToString();
    }

    private static byte[] PadMessage(byte[] message)
    {
        int length = message.Length * 8; // In bits
        int paddingLength = (448 - length) % 512;

        byte[] padding = new byte[(paddingLength + 64) / 8]; // 64 bits for length
        padding[0] = 0x80;

        byte[] lengthBytes = BitConverter.GetBytes((ulong)length);
        Array.Reverse(lengthBytes); // Big-endian
        Array.Copy(lengthBytes, 0, padding, padding.Length - 8, 8);

        byte[] paddedMessage = new byte[message.Length + padding.Length];
        Array.Copy(message, 0, paddedMessage, 0, message.Length);
        Array.Copy(padding, 0, paddedMessage, message.Length, padding.Length);

        return paddedMessage;
    }

    private static void ProcessBlock(byte[] block, uint[] hashValues)
    {
        // Message schedule array
        uint[] w = new uint[64];
        for (int i = 0; i < 16; i++)
        {
            w[i] = BitConverter.ToUInt32(block, i * 4);
            Array.Reverse(BitConverter.GetBytes(w[i])); // Big-endian conversion
        }

        // Extend the message schedule to 64 words
        for (int i = 16; i < 64; i++)
        {
            w[i] = Sigma1(w[i - 2]) + w[i - 7] + Sigma0(w[i - 15]) + w[i - 16];
        }

        // Initialize working variables
        uint a = hashValues[0];
        uint b = hashValues[1];
        uint c = hashValues[2];
        uint d = hashValues[3];
        uint e = hashValues[4];
        uint f = hashValues[5];
        uint g = hashValues[6];
        uint h = hashValues[7];

        // Main loop
        for (int i = 0; i < 64; i++)
        {
            uint temp1 = h + Sigma1(e) + Ch(e, f, g) + K[i] + w[i];
            uint temp2 = Sigma0(a) + Maj(a, b, c);

            h = g;
            g = f;
            f = e;
            e = d + temp1;
            d = c;
            c = b;
            b = a;
            a = temp1 + temp2;
        }

        // Update hash values
        hashValues[0] += a;
        hashValues[1] += b;
        hashValues[2] += c;
        hashValues[3] += d;
        hashValues[4] += e;
        hashValues[5] += f;
        hashValues[6] += g;
        hashValues[7] += h;
    }

    // Functions used in the algorithm

    private static uint Sigma0(uint x) => RotateRight(x, 7) ^ RotateRight(x, 18) ^ RotateLeft(x, 3);
    private static uint Sigma1(uint x) => RotateRight(x, 17) ^ RotateRight(x, 19) ^ RotateLeft(x, 10);
    private static uint Ch(uint x, uint y, uint z) => (x & y) ^ (~x & z);
    private static uint Maj(uint x, uint y, uint z) => (x & y) ^ (x & z) ^ (y & z);
    private static uint RotateRight(uint x, int n) => (x >> n) | (x << (32 - n));
    private static uint RotateLeft(uint x, int n) => (x << n) | (x >> (32 - n));


}
