pipeline {
    agent any

    environment {
        DOTNET_PATH = 'C:\\Program Files\\dotnet' // Path to .NET SDK
        CHROME_DRIVER_PATH = 'C:\\Users\\venkatesh.b\\Desktop\\DailyCheck_WebAutomation\\packages\\Selenium.WebDriver.ChromeDriver.90.0.4430.2400' // Path to ChromeDriver
    }

    stages {
        stage('Validate Paths') {
            steps {
                echo 'Validating critical paths...'
                bat """
                IF NOT EXIST "${DOTNET_PATH}\\dotnet.exe" (
                    echo .NET SDK not found at ${DOTNET_PATH} && exit 1
                )
                IF NOT EXIST "${CHROME_DRIVER_PATH}" (
                    echo ChromeDriver not found at ${CHROME_DRIVER_PATH} && exit 1
                )
                """
            }
        }

        stage('Checkout') {
            steps {
                echo 'Checking out the code...'
                checkout scm
            }
        }

        stage('Restore Dependencies') {
            steps {
                echo 'Restoring NuGet dependencies...'
                bat '"${DOTNET_PATH}\\dotnet.exe" restore "${WORKSPACE}"'
            }
        }

        stage('Build') {
            steps {
                echo 'Building the solution...'
                bat '"${DOTNET_PATH}\\dotnet.exe" build "${WORKSPACE}" --no-restore --configuration Release'
            }
        }

        stage('Run Tests') {
            steps {
                echo 'Running tests with SpecFlow...'
                bat """
                SET CHROME_DRIVER_PATH=${CHROME_DRIVER_PATH}
                "${DOTNET_PATH}\\dotnet.exe" test "${WORKSPACE}" --no-build --logger:trx
                """
            }
        }

        stage('Publish Results') {
            steps {
                echo 'Publishing test results...'
                publishHTML([allowMissing: false,
                             alwaysLinkToLastBuild: true,
                             keepAll: true,
                             reportDir: 'TestResults',
                             reportFiles: 'index.html',
                             reportName: 'Test Report'])
            }
        }
    }

    post {
        always {
            echo 'Cleaning workspace...'
            cleanWs()
        }
        success {
            echo 'Build and tests completed successfully!'
        }
        failure {
            echo 'Build or tests failed.'
        }
    }
}
