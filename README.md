# ppUpdator
👇 ppUpdator is a Application Updator.

## How to use

1. Step one, copy all the ppUpdator binary files to your application root directory.
2. Step two, edit the [ppu_update_info.json] file tomake sure you are ready to update your application.

## ppu_update_info.json

```json
{
    "DownloadUrl":"https://raw.githubusercontent.com/cyf-gh/Petri-Dish/master/.bin/Release.rar",
    "DownloadZipType":".rar",
    "RunAfterUpdate":"PetriDish.App.exe",
    "BaseFolderName":"Release",
    "IgnoreCopyFileNames":[
        "data\\project_dir.json",
        "Newtonsoft.Json.dll"
    ]
}
```

* DownloadUrl: which is your permanently http url of your latest compressed file which contains your application.

* DownloadZipType: assigns the type of your compress file.

* RunAfterUpdate: is the main executable file of your application.

* BaseFolderName: is the root folder of your compress file. 

  eg:

  ```
  foo.rar/release/*.*
  ```

  then you should assign this value to release.