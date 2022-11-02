const path = require('path')

module.exports = {
  mode: "development",
  entry: './src/index.tsx',
  output: {
    path: path.resolve(__dirname, './dist'),
    filename: 'bundle.js'
  },
  module: {
    rules: [
      {
        test: /\.(ts)x?$/,
        exclude: /node_modules/,
        use: {
          loader: 'ts-loader',
        },
      },
    ],
  },
  devServer: {
    contentBase: path.resolve(__dirname, '.'),
    compress: true,
    port: 3000,
    proxy: {
      '/api': {
        target: 'http://localhost:5028',
        pathRewrite: { '^/api': '' },
        headers: {
          'X-Api-BaseUrl': '/api'
        }
      }
    },
    historyApiFallback: {
      index: 'index.html'
    }
  }
}