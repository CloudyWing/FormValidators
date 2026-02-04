import os
import codecs

def convert_to_utf8_bom(filepath):
    try:
        with open(filepath, 'rb') as f:
            content = f.read()

        # Check if already UTF-8 BOM
        if content.startswith(codecs.BOM_UTF8):
            return False

        # Try to decode as utf-8 first
        try:
            decoded = content.decode('utf-8')
        except UnicodeDecodeError:
            # Try other common encodings
            try:
                decoded = content.decode('cp950') # Traditional Chinese (Big5) often used in older projects
            except UnicodeDecodeError:
                try:
                    decoded = content.decode('gb2312')
                except UnicodeDecodeError:
                     # Fallback to latin-1 or similar if needed, or skip
                     print(f"Skipping {filepath}: Unknown encoding")
                     return False

        # Write back with BOM
        with open(filepath, 'wb') as f:
            f.write(codecs.BOM_UTF8 + decoded.encode('utf-8'))
        return True
    except Exception as e:
        print(f"Error processing {filepath}: {e}")
        return False

def main():
    extensions = ['.cs', '.csproj', '.md', '.sln']
    count = 0
    for root, dirs, files in os.walk('.'):
        if '.git' in dirs:
            dirs.remove('.git')
        if 'bin' in dirs:
            dirs.remove('bin')
        if 'obj' in dirs:
            dirs.remove('obj')

        for file in files:
            if any(file.endswith(ext) for ext in extensions):
                filepath = os.path.join(root, file)
                if convert_to_utf8_bom(filepath):
                    print(f"Converted: {filepath}")
                    count += 1
    print(f"Total converted: {count}")

if __name__ == "__main__":
    main()
