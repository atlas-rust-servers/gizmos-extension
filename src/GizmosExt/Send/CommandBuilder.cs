using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Facepunch;
using UnityEngine;

namespace Oxide.Ext.GizmosExt;

internal static class CommandBuilder
{
    public static string Build<T0, T1, T2, T3, T4, T5, T6, T7>(
        string cmd, T0 a0, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7)
    {
        StringBuilder sb = Begin(cmd);
        Append(sb, a0);
        Append(sb, a1);
        Append(sb, a2);
        Append(sb, a3);
        Append(sb, a4);
        Append(sb, a5);
        Append(sb, a6);
        Append(sb, a7);
        return End(sb);
    }

    public static string Build<T0, T1, T2, T3, T4, T5, T6, T7, T8>(
        string cmd, T0 a0, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8)
    {
        StringBuilder sb = Begin(cmd);
        Append(sb, a0);
        Append(sb, a1);
        Append(sb, a2);
        Append(sb, a3);
        Append(sb, a4);
        Append(sb, a5);
        Append(sb, a6);
        Append(sb, a7);
        Append(sb, a8);
        return End(sb);
    }

    public static string Build<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        string cmd, T0 a0, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8, T9 a9)
    {
        StringBuilder sb = Begin(cmd);
        Append(sb, a0);
        Append(sb, a1);
        Append(sb, a2);
        Append(sb, a3);
        Append(sb, a4);
        Append(sb, a5);
        Append(sb, a6);
        Append(sb, a7);
        Append(sb, a8);
        Append(sb, a9);
        return End(sb);
    }

    private static StringBuilder Begin(string cmd)
    {
        var sb = Pool.Get<StringBuilder>();
        sb.Append(cmd);
        return sb;
    }

    private static string End(StringBuilder sb)
    {
        string result = sb.ToString();
        Pool.FreeUnmanaged(ref sb);
        return result;
    }

    /// <summary>
    /// Similar to <see cref="ConsoleSystem.BuildCommand"/>.
    /// </summary>
    private static void Append<T>(StringBuilder sb, T value)
    {
        sb.Append(' ');

        if (typeof(T) == typeof(Color))
        {
            Color c = Unsafe.As<T, Color>(ref value);
            sb.Append('"').Append(c.r).Append(',').Append(c.g).Append(',').Append(c.b).Append(',').Append(c.a).Append('"');
        }
        else if (typeof(T) == typeof(Vector3))
        {
            Vector3 v = Unsafe.As<T, Vector3>(ref value);
            sb.Append('"').Append(v.x).Append(',').Append(v.y).Append(',').Append(v.z).Append('"');
        }
        else if (typeof(T) == typeof(string))
        {
            string s = Unsafe.As<T, string>(ref value);
            if (s == null)
                sb.Append("\"\"");
            else
                sb.QuoteSafe(s);
        }
        else if (typeof(T) == typeof(float))
        {
            float f = Unsafe.As<T, float>(ref value);
            sb.QuoteSafe(f.ToString(CultureInfo.InvariantCulture));
        }
        else if (typeof(T) == typeof(bool))
        {
            bool b = Unsafe.As<T, bool>(ref value);
            sb.QuoteSafe(b.ToString());
        }
        else if (typeof(T) == typeof(NetworkableId))
        {
            NetworkableId id = Unsafe.As<T, NetworkableId>(ref value);
            sb.QuoteSafe(id.ToString());
        }
        else
        {
            throw new NotSupportedException($"Unsupported ddraw argument type: {typeof(T)}");
        }
    }
}
