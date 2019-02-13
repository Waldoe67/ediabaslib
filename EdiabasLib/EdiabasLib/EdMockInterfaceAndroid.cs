using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Android.OS;

namespace EdiabasLib {
    public class EdMockInterface {
        public const string PortId = "MOCK";

        static EdMockInterface() {
        }

        public static EdiabasNet Ediabas { get; set; }

        public static bool InterfaceConnect(string port, object parameter) {
            Console.WriteLine("InterfaceConnect");
            return true;
        }

        public static bool InterfaceDisconnect() {
            return true;
        }

        public static EdInterfaceObd.InterfaceErrorResult InterfaceSetConfig(EdInterfaceObd.Protocol protocol, int baudRate, int dataBits, EdInterfaceObd.SerialParity parity, bool allowBitBang) {
            return EdInterfaceObd.InterfaceErrorResult.NoError;
        }

        public static bool InterfaceSetDtr(bool dtr) {
            return true;
        }

        public static bool InterfaceSetRts(bool rts) {
            return true;
        }

        public static bool InterfaceGetDsr(out bool dsr) {
            dsr = true;
            return true;
        }

        public static bool InterfaceSetBreak(bool enable) {
            return false;
        }

        public static bool InterfaceSetInterByteTime(int time) {
            return true;
        }

        public static bool InterfaceSetCanIds(int canTxId, int canRxId, EdInterfaceObd.CanFlags canFlags) {
            return true;
        }

        public static bool InterfacePurgeInBuffer() {
            return true;
        }

        public static bool InterfaceAdapterEcho() {
            return false;
        }

        public static bool InterfaceHasPreciseTimeout() {
            return false;
        }

        public static bool InterfaceHasAutoBaudRate() {
            return true;
        }

        public static bool InterfaceHasAutoKwp1281() {
            return false;
        }

        public static bool InterfaceHasIgnitionStatus() {
            return true;
        }

        public static bool InterfaceSendData(byte[] sendData, int length, bool setDtr, double dtrTimeCorr) {
            return true;
        }

        public static bool InterfaceReceiveData(byte[] receiveData, int offset, int length, int timeout, int timeoutTelEnd, EdiabasNet ediabasLog) {
            return true;
        }

        public static bool InterfaceSendPulse(UInt64 dataBits, int length, int pulseWidth, bool setDtr, bool bothLines, int autoKeyByteDelay) {
            return true;
        }
    }
}
