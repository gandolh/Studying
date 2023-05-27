import './globals.css'
import Head from './head'

export default function RootLayout({
  children,
}: {
  children: React.ReactNode
}) {
  return (
    <html lang="en">
      <Head/>
      <body>
      <nav>
      <h1>logo</h1>
      <ul>
        <a href="/">Home</a>
        <a href="about">About</a>
      </ul>
      </nav>
        {children}</body>
    </html>
  )
}
