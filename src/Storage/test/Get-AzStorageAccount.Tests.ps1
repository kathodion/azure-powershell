$TestRecordingFile = Join-Path $PSScriptRoot 'C:\Users\niassis\source\repos\generating\azure-powershell\src\Storage\test' 'Get-AzStorageAccount.Recording.json'

. (Join-Path $PSScriptRoot '..\generated\runtime' 'HttpPipelineMocking.ps1')

Describe 'Get-AzStorageAccount' {
    It 'List2' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'List3' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
