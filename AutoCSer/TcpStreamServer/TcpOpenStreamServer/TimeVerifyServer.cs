﻿using System;

namespace AutoCSer.Net.TcpOpenStreamServer
{
    /// <summary>
    /// 时间验证服务
    /// </summary>
    public abstract class TimeVerifyServer : TcpStreamServer.TimeVerifyServer<ServerAttribute, Server, ServerSocket, ServerSocketSender>
    {
    }
}
