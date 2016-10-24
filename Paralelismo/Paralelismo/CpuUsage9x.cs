using System;
using Microsoft.Win32;

namespace Paralelismo.Utilities {
	/// <summary>
	/// Inherits the CPUUsage class and implements the Query method for Windows 9x systems.
	/// </summary>
	/// <remarks>
	/// <p>This class works on Windows 98 and Windows Millenium Edition.</p>
	/// <p>You should not use this class directly in your code. Use the CPUUsage.Create() method to instantiate a CPUUsage object.</p>
	/// </remarks>
	internal sealed class CpuUsage9x : CpuUsage {
		/// <summary>
		/// Initializes a new CPUUsage9x instance.
		/// </summary>
		/// <exception cref="NotSupportedException">One of the system calls fails.</exception>
		public CpuUsage9x() {
			try {
				// start the counter by reading the value of the 'StartStat' key
				RegistryKey startKey = Registry.DynData.OpenSubKey(@"PerfStats\StartStat", false);
				if (startKey == null)
					throw new NotSupportedException();
				startKey.GetValue(@"KERNEL\CPUUsage");
				startKey.Close();
				// open the counter's value key
				m_StatData = Registry.DynData.OpenSubKey(@"PerfStats\StatData", false);
				if (m_StatData == null)
					throw new NotSupportedException();
			} catch (NotSupportedException e) {
				throw e;
			} catch (Exception e) {
				throw new NotSupportedException("Error while querying the system information.", e);
			}
		}
		/// <summary>
		/// Determines the current average CPU load.
		/// </summary>
		/// <returns>An integer that holds the CPU load percentage.</returns>
		/// <exception cref="NotSupportedException">One of the system calls fails. The CPU time can not be obtained.</exception>
		public override int Query() {
			try {
				return (int)m_StatData.GetValue(@"KERNEL\CPUUsage");
			} catch (Exception e) {
				throw new NotSupportedException("Error while querying the system information.", e);
			}
		}
		/// <summary>
		/// Closes the allocated resources.
		/// </summary>
		~CpuUsage9x() {
			try {
				m_StatData.Close();
			} catch {}
			// stopping the counter
			try {
				RegistryKey stopKey = Registry.DynData.OpenSubKey(@"PerfStats\StopStat", false);
				stopKey.GetValue(@"KERNEL\CPUUsage", false);
				stopKey.Close();
			} catch {}
		}
        ///Es la clave del registro que se utiliza para leer la carga de la CPU.
        private RegistryKey m_StatData;
        
	}
}
