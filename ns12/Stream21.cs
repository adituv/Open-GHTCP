using Compression.Tar;
using ns13;
using System;
using System.IO;

namespace ns12
{
	public class Stream21 : Stream
	{
		public long long_0;

		public long long_1;

		public byte[] byte_0;

		public Class206 class206_0;

		private Stream stream_0;

		public override bool CanRead
		{
			get
			{
				return this.stream_0.CanRead;
			}
		}

		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		public override long Length
		{
			get
			{
				return this.stream_0.Length;
			}
		}

		public override long Position
		{
			get
			{
				return this.stream_0.Position;
			}
			set
			{
				throw new NotSupportedException("TarInputStream Seek not supported");
			}
		}

		public override void Flush()
		{
			this.stream_0.Flush();
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException("TarInputStream Seek not supported");
		}

		public override void SetLength(long value)
		{
			throw new NotSupportedException("TarInputStream SetLength not supported");
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new NotSupportedException("TarInputStream Write not supported");
		}

		public override void WriteByte(byte value)
		{
			throw new NotSupportedException("TarInputStream WriteByte not supported");
		}

		public override int ReadByte()
		{
			byte[] array = new byte[1];
			int num = this.Read(array, 0, 1);
			if (num <= 0)
			{
				return -1;
			}
			return (int)array[0];
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			int num = 0;
			if (this.long_1 >= this.long_0)
			{
				return 0;
			}
			long num2 = (long)count;
			if (num2 + this.long_1 > this.long_0)
			{
				num2 = this.long_0 - this.long_1;
			}
			if (this.byte_0 != null)
			{
				int num3 = (num2 > (long)this.byte_0.Length) ? this.byte_0.Length : ((int)num2);
				Array.Copy(this.byte_0, 0, buffer, offset, num3);
				if (num3 >= this.byte_0.Length)
				{
					this.byte_0 = null;
				}
				else
				{
					int num4 = this.byte_0.Length - num3;
					byte[] destinationArray = new byte[num4];
					Array.Copy(this.byte_0, num3, destinationArray, 0, num4);
					this.byte_0 = destinationArray;
				}
				num += num3;
				num2 -= (long)num3;
				offset += num3;
			}
			while (num2 > 0L)
			{
				byte[] array = this.class206_0.method_2();
				if (array == null)
				{
					throw new TarException("unexpected EOF with " + num2 + " bytes unread");
				}
				int num5 = (int)num2;
				int num6 = array.Length;
				if (num6 > num5)
				{
					Array.Copy(array, 0, buffer, offset, num5);
					this.byte_0 = new byte[num6 - num5];
					Array.Copy(array, num5, this.byte_0, 0, num6 - num5);
				}
				else
				{
					num5 = num6;
					Array.Copy(array, 0, buffer, offset, num6);
				}
				num += num5;
				num2 -= (long)num5;
				offset += num5;
			}
			this.long_1 += (long)num;
			return num;
		}

		public override void Close()
		{
			this.class206_0.method_8();
		}
	}
}
