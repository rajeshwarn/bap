﻿namespace BAP.Loader.MachO
{
	/*
	 * After MacOS X 10.1 when a new load command is added that is required to be
	 * understood by the dynamic linker for the image to execute properly the
	 * LC_REQ_DYLD bit will be or'ed into the load command constant.  If the dynamic
	 * linker sees such a load command it it does not understand will issue a
	 * "unknown load command required for execution" error and refuse to use the
	 * image.  Other load commands without this bit that are not understood will
	 * simply be ignored.
	 */
	public enum LC : uint
	{
		LC_REQ_DYLD              = 0x80000000,

		/* Constants for the cmd field of all load commands, the type */
		LC_SEGMENT               = 0x1 ,  /* segment of this file to be mapped */
		LC_SYMTAB                = 0x2 ,  /* link-edit stab symbol table info */
		LC_SYMSEG                = 0x3 ,  /* link-edit gdb symbol table info (obsolete) */
		LC_THREAD                = 0x4 ,  /* thread */
		LC_UNIXTHREAD            = 0x5 ,  /* unix thread (includes a stack) */
		LC_LOADFVMLIB            = 0x6 ,  /* load a specified fixed VM shared library */
		LC_IDFVMLIB              = 0x7 ,  /* fixed VM shared library identification */
		LC_IDENT                 = 0x8 ,  /* object identification info (obsolete) */
		LC_FVMFILE               = 0x9 ,  /* fixed VM file inclusion (internal use) */
		LC_PREPAGE               = 0xa ,  /* prepage command (internal use) */
		LC_DYSYMTAB              = 0xb ,  /* dynamic link-edit symbol table info */
		LC_LOAD_DYLIB            = 0xc ,  /* load a dynamically linked shared library */
		LC_ID_DYLIB              = 0xd ,  /* dynamically linked shared lib ident */
		LC_LOAD_DYLINKER         = 0xe ,  /* load a dynamic linker */
		LC_ID_DYLINKER           = 0xf ,  /* dynamic linker identification */
		LC_PREBOUND_DYLIB        = 0x10,  /* modules prebound for a dynamically */
		/*  linked shared library */
		LC_ROUTINES              = 0x11,  /* image routines */
		LC_SUB_FRAMEWORK         = 0x12,  /* sub framework */
		LC_SUB_UMBRELLA          = 0x13,  /* sub umbrella */
		LC_SUB_CLIENT            = 0x14,  /* sub client */
		LC_SUB_LIBRARY           = 0x15,  /* sub library */
		LC_TWOLEVEL_HINTS        = 0x16,  /* two-level namespace lookup hints */
		LC_PREBIND_CKSUM         = 0x17,  /* prebind checksum */

		/*
		 * load a dynamically linked shared library that is allowed to be missing
		 * (all symbols are weak imported).
		 */
		LC_LOAD_WEAK_DYLIB        = (0x18 | LC_REQ_DYLD),

		LC_SEGMENT_64             = 0x19                    ,/* 64-bit segment of this file to be mapped */
		LC_ROUTINES_64            = 0x1a                    ,/* 64-bit image routines */
		LC_UUID                   = 0x1b                    ,/* the uuid */
		LC_RPATH                  = (0x1c | LC_REQ_DYLD)    ,/* runpath additions */
		LC_CODE_SIGNATURE         = 0x1d                    ,/* local of code signature */
		LC_SEGMENT_SPLIT_INFO     = 0x1e                    ,/* local of info to split segments */
		LC_REEXPORT_DYLIB         = (0x1f | LC_REQ_DYLD)    ,/* load and re-export dylib */
		LC_LAZY_LOAD_DYLIB        = 0x20                    ,/* delay load of dylib until first use */
		LC_ENCRYPTION_INFO        = 0x21                    ,/* encrypted segment information */
		LC_DYLD_INFO              = 0x22                    ,/* compressed dyld information */
		LC_DYLD_INFO_ONLY         = (0x22|LC_REQ_DYLD)      ,/* compressed dyld information only */
		LC_LOAD_UPWARD_DYLIB      = (0x23 | LC_REQ_DYLD)    ,/* load upward dylib */
		LC_VERSION_MIN_MACOSX     = 0x24                    ,/* build for MacOSX min OS version */
		LC_VERSION_MIN_IPHONEOS   = 0x25                    ,/* build for iPhoneOS min OS version */
		LC_FUNCTION_STARTS        = 0x26                    ,/* compressed table of function start addresses */
		LC_DYLD_ENVIRONMENT       = 0x27                    ,/* string for dyld to treat like environment variable */
		LC_MAIN                   = (0x28|LC_REQ_DYLD)      ,/* replacement for LC_UNIXTHREAD */
		LC_DATA_IN_CODE           = 0x29                    ,/* table of non-instructions in __text */
		LC_SOURCE_VERSION         = 0x2A                    ,/* source version used to build binary */
		LC_DYLIB_CODE_SIGN_DRS    = 0x2B                    ,/* Code signing DRs copied from linked dylibs */
		LC_ENCRYPTION_INFO_64     = 0x2C                    ,/* 64-bit encrypted segment information */
		LC_LINKER_OPTION          = 0x2D                    ,/* linker options in MH_OBJECT files */
	}
}