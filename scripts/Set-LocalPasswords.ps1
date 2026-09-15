# Run locally as the SAME Windows user who runs Visual Studio.
# The MySQL account must already exist. This does not create a MySQL user.
$ErrorActionPreference = 'Stop'

function Set-PrivateUserVariable([string]$VariableName, [string]$Prompt) {
    $secureValue = Read-Host $Prompt -AsSecureString
    $buffer = [IntPtr]::Zero
    try {
        $buffer = [Runtime.InteropServices.Marshal]::SecureStringToBSTR($secureValue)
        $plainValue = [Runtime.InteropServices.Marshal]::PtrToStringBSTR($buffer)
        if ([string]::IsNullOrEmpty($plainValue)) {
            throw "$VariableName cannot be empty. Its previous value was not changed."
        }
        [Environment]::SetEnvironmentVariable($VariableName, $plainValue, 'User')
    }
    finally {
        $plainValue = $null
        if ($buffer -ne [IntPtr]::Zero) {
            [Runtime.InteropServices.Marshal]::ZeroFreeBSTR($buffer)
        }
        $secureValue.Dispose()
    }
}

Set-PrivateUserVariable 'CG_DB_PASSWORD' 'Enter the password already assigned to cg_app in MySQL'
Set-PrivateUserVariable 'CG_APP_PASSWORD' 'Choose the separate password for the app admin login'
Write-Host 'User-level passwords saved. Restart the application and Visual Studio.'
Write-Host 'These variables are local configuration, not encrypted application authentication.'
