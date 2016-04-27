﻿// Copyright (c) 2007-2016 CSJ2K contributors.
// Licensed under the BSD 3-Clause License.

namespace CSJ2K.Util
{
    public class BitmapWrapperFactory
    {
        #region FIELDS

        private static IBitmapWrapperCreator _creator;

        #endregion

#if DOTNET
		#region CONSTRUCTORS

		static BitmapWrapperFactory()
		{
			RegisterCreator(new WinformsBitmapWrapperCreator());
		}

		#endregion
#endif

        #region METHODS

        public static void RegisterCreator(IBitmapWrapperCreator creator)
        {
            _creator = creator;
        }

        internal static IBitmapWrapper New(int width, int height, int numberOfComponents)
        {
            return _creator.Create(width, height, numberOfComponents);
        }

        #endregion
    }
}
