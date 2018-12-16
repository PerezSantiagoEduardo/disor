
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;


public class Espacio
{
    public enum ColorChannel: int { RED = 2, GREEN = 1, BLUE = 0, ALPHA = 3 }

    #region Fields
    private int RowSizeBytes;
    private byte[] PixBytes;
    private BitmapData mapaDatos; 
    #endregion

    #region Public Metodos
    // Lock the bitmap's data.
    public void LockBitmap(Bitmap bm, bool ReadOnly = false)
    {
        // Lock the bitmap data.
        Rectangle bounds = new Rectangle(0, 0, bm.Width, bm.Height);
        mapaDatos = bm.LockBits(bounds, ReadOnly ? ImageLockMode.ReadOnly : ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
        RowSizeBytes = mapaDatos.Stride;

        
        int total_size = mapaDatos.Stride * mapaDatos.Height;
        PixBytes = new byte[total_size + 1];

       
        Marshal.Copy(mapaDatos.Scan0, PixBytes, 0, total_size);
    }

    public void UnlockBitmap(Bitmap bm)
    {
       
        int total_size = mapaDatos.Stride * mapaDatos.Height;
        Marshal.Copy(PixBytes, 0, mapaDatos.Scan0, total_size);

        bm.UnlockBits(mapaDatos);

        PixBytes = null;
        mapaDatos = null;
    }

    public Color obtenerPixel(int x, int y)
    {
        return Color.FromArgb(PixBytes[obtenerPosiArre(x, y, ColorChannel.ALPHA)],
                              PixBytes[obtenerPosiArre(x, y, ColorChannel.RED)],
                              PixBytes[obtenerPosiArre(x, y, ColorChannel.GREEN)],
                              PixBytes[obtenerPosiArre(x, y, ColorChannel.BLUE)]);
    }

    public void SetPixel(int x, int y, Color c)
    {
        PixBytes[obtenerPosiArre(x, y, ColorChannel.RED)] = c.R;
        PixBytes[obtenerPosiArre(x, y, ColorChannel.GREEN)] = c.G;
        PixBytes[obtenerPosiArre(x, y, ColorChannel.BLUE)] = c.B;
        PixBytes[obtenerPosiArre(x, y, ColorChannel.ALPHA)] = c.A;
    }

    public int obtenerPosiArre(int x, int y, ColorChannel c)
    {
        return Convert.ToInt32((RowSizeBytes * y + x * 4) + c);
    } 
    #endregion

}

