pipeline {
    agent {
        label 'windows'  // This assumes you're running Jenkins on a Windows node
    }
    environment {
        // Define environment variables if needed
        VSTEST_PATH = "C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\Common7\\IDE\\Extensions\\TestPlatform\\vstest.console.exe"
    }
    stages {
        stage('Checkout Code') {
            steps {
                // Checkout the repository to get the latest code
                checkout scm
            }
        }
        stage('Build Project') {
            steps {
                // Build the project (this assumes your project is a .NET project)
                bat 'dotnet build D:\\DailyCheck_WebAutomation\\DailyCheck_WebAutomation.sln -c Release'
            }
        }
        stage('Run Smoke Tests') {
            steps {
                // Navigate to the Debug folder dynamically (using the Git repo root)
                script {
                    def repoRoot = bat(script: 'git rev-parse --show-toplevel', returnStdout: true).trim()
                    def testPath = "${repoRoot}\\DailyCheck_WebAutomation\\bin\\Debug"
                    echo "Running tests in: ${testPath}"
                }
                // Run the smoke tests using vstest.console.exe
                bat """
                cd /d ${testPath}
                "${VSTEST_PATH}" DailyCheck_WebAutomation.dll /TestCaseFilter:"TestCategory=smoke"
                """
            }
        }
    }
    post {
        always {
            // Actions to run after the tests, like archiving test results (optional)
            junit '**/TestResults/*.xml'  // Adjust this path based on your test result location
        }
        success {
            // Actions if the build and tests pass (optional)
            echo 'Tests passed successfully!'
        }
        failure {
            // Actions if the build or tests fail (optional)
            echo 'Tests failed!'
        }
    }
}
