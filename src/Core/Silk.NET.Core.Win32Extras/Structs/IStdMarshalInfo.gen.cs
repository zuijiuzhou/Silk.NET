// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Guid("00000018-0000-0000-c000-000000000046")]
    [NativeName("Name", "IStdMarshalInfo")]
    public unsafe partial struct IStdMarshalInfo : IComVtbl<IStdMarshalInfo>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("00000018-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IStdMarshalInfo val)
            => Unsafe.As<IStdMarshalInfo, Silk.NET.Core.Native.IUnknown>(ref val);

        public IStdMarshalInfo
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IStdMarshalInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IStdMarshalInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IStdMarshalInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStdMarshalInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IStdMarshalInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStdMarshalInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IStdMarshalInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IStdMarshalInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IStdMarshalInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IStdMarshalInfo*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IStdMarshalInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IStdMarshalInfo*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClassForHandler(uint dwDestContext, void* pvDestContext, Guid* pClsid)
        {
            var @this = (IStdMarshalInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IStdMarshalInfo*, uint, void*, Guid*, int>)@this->LpVtbl[3])(@this, dwDestContext, pvDestContext, pClsid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClassForHandler(uint dwDestContext, void* pvDestContext, ref Guid pClsid)
        {
            var @this = (IStdMarshalInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pClsidPtr = &pClsid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStdMarshalInfo*, uint, void*, Guid*, int>)@this->LpVtbl[3])(@this, dwDestContext, pvDestContext, pClsidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClassForHandler<T0>(uint dwDestContext, ref T0 pvDestContext, Guid* pClsid) where T0 : unmanaged
        {
            var @this = (IStdMarshalInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStdMarshalInfo*, uint, void*, Guid*, int>)@this->LpVtbl[3])(@this, dwDestContext, pvDestContextPtr, pClsid);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetClassForHandler<T0>(uint dwDestContext, ref T0 pvDestContext, ref Guid pClsid) where T0 : unmanaged
        {
            var @this = (IStdMarshalInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                fixed (Guid* pClsidPtr = &pClsid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IStdMarshalInfo*, uint, void*, Guid*, int>)@this->LpVtbl[3])(@this, dwDestContext, pvDestContextPtr, pClsidPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IStdMarshalInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IStdMarshalInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
